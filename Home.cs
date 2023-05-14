using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace MigrationTool
{
  public partial class MigrationTool : Form
  {
    private MigrationController migCtrl = new MigrationController();
    private LinkedList<string> companies;
    private LinkedListNode<string> companyOnRun;

    public MigrationTool()
    {
      InitializeComponent();
    }
    private void MigrationTool_Load(object sender, EventArgs e)
    {
      MigrationLog.SetTextBox(this.logTextBox);
      try
      {
        AppSettingsHelper.LoadFromFile();
        AppSettingsHelper.LogAppSettings();
      }
      catch (Exception ex)
      {
        MigrationLog.ShowError("AppSettings.json not loaded: " + ex.Message);
      }
    }

    private void loadToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileDialog open = new OpenFileDialog();
      open.Filter = "Sql|*.sql";
      if (open.ShowDialog() == DialogResult.OK)
        migCtrl.LoadMigrationFile(open.FileName);
    }

    private void loadNewToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileDialog open = new OpenFileDialog();
      open.Filter = "Sql|*.sql";
      if (open.ShowDialog() == DialogResult.OK)
        migCtrl.LoadMigrationFileNew(open.FileName);
    }

    private void clearLogToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MigrationLog.Clear();
    }

    private void queryToolStripMenuItem_Click(object sender, EventArgs e)
    {
      QueryForm queryForm = new QueryForm(migCtrl);
      queryForm.ShowDialog();
    }

    private void runToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (migCtrl.queries.Count == 0)
      {
        MigrationLog.ShowError("File non caricato");
        return;
      }

      // check approfondito se tutti i setup sono compilati
      if (!AppSettingsHelper.Loaded)
      {
        MigrationLog.ShowError("Setup not loaded");
        return;
      }

      if (runBackgroundWorker.IsBusy)
      {
        MigrationLog.ShowError("Run in corso");
        return;
      }

      companies = new LinkedList<string>(AppSettingsHelper.Config.Companies.Split(','));
      companyOnRun = companies.First;
      InitRun();
    }

    private void cancelButton_Click(object sender, EventArgs e)
    {
      if (runBackgroundWorker.WorkerSupportsCancellation)
        runBackgroundWorker.CancelAsync();
    }

    private void runBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      BackgroundWorker worker = sender as BackgroundWorker;

      for (int i = 0; i < migCtrl.queries.Count; i++)
      {
        if (worker.CancellationPending == true)
        {
          e.Cancel = true;
          break;
        }
        else
        {
          migCtrl.queries[i].Execute(AppSettingsHelper.RunQueryOnlyWithCompany, companyOnRun.Value);
          worker.ReportProgress(i);
        }
      }
    }

    private void runBackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      //e.ProgressPercentage
      runProgressBar.PerformStep();
    }

    private void runBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      runProgressBar.Value = 0;
      SqlController.Disconnect();

      if (e.Cancelled == true)
        MigrationLog.Write("CANCELED: " + DateTime.Now.ToString() + " - " + startTextBox.Text);
      else if (e.Error != null)
        MigrationLog.Write("ERROR: " + e.Error.Message + DateTime.Now.ToString() + " - " + startTextBox.Text);
      else
      {
        MigrationLog.Write("DONE: " + companyOnRun.Value + " - " + startTextBox.Text + " - " + DateTime.Now.ToString());
        companyOnRun = companyOnRun.Next;
        if (companyOnRun != null)
        {
          AppSettingsHelper.RunQueryOnlyWithCompany = true;
          InitRun();
        }
        else
        {
          AppSettingsHelper.RunQueryOnlyWithCompany = false;
        }
      }
    }

    private void shrinkStripMenuItem_Click(object sender, EventArgs e)
    {
      if (!AppSettingsHelper.Loaded)
      {
        MigrationLog.ShowError("Setup not loaded");
        return;
      }
      try
      {
        SqlController.Connect(AppSettingsHelper.Config.Connection);
      }
      catch (Exception ex)
      {
        MigrationLog.ShowError("Errore in connessione: " + ex.Message);
        return;
      }
      SqlController.ShrinkFile(AppSettingsHelper.Config.DBBC, AppSettingsHelper.Config.LogToShrink);
    }

    private void setupToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SetupForm setupForm = new SetupForm();
      setupForm.ShowDialog();
    }

    private void exportToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string filePath = Directory.GetCurrentDirectory() + "\\NewMigrationFile.sql";
      MigrationLog.Write("Exporting file to: " + filePath);
      migCtrl.ExportMigrationFile(filePath);
      MigrationLog.Write("File exported");
    }

    private void InitRun()
    {
      try
      {
        SqlController.Connect(AppSettingsHelper.Config.Connection);
      }
      catch (Exception ex)
      {
        MigrationLog.ShowError("Connection error: " + ex.Message);
        return;
      }

      startTextBox.Text = DateTime.Now.ToString();
      companyOnRunTextBox.Text = companyOnRun.Value;
      MigrationLog.Write(companyOnRun.Value + " - " + startTextBox.Text);

      runProgressBar.Maximum = migCtrl.queries.Count;
      runProgressBar.Minimum = 0;
      runProgressBar.Value = 0;
      runProgressBar.Step = 1;

      runBackgroundWorker.RunWorkerAsync();
    }
  }
}
