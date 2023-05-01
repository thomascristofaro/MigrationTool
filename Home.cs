using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MigrationTool
{
  public partial class MigrationTool : Form
  {
    private MigrationController migCtrl = new MigrationController();
    public MigrationTool()
    {
      InitializeComponent();
    }

    private void fileToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
    }

    private void loadToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileDialog open = new OpenFileDialog();
      open.Filter = "Sql|*.sql";
      if (open.ShowDialog() == DialogResult.OK)
      {
        migCtrl.LoadMigrationFile(open.FileName);
        migFileTextBox.Text = open.FileName;
      }
    }

    private void MigrationTool_Load(object sender, EventArgs e)
    {
      MigrationLog.SetTextBox(this.logTextBox);
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

      if (dbBCTextBox.Text == "" || dbNavTextBox.Text == "" || 
          companiesTextBox.Text == "" || connTextBox.Text == "")
      {
        MigrationLog.ShowError("Inserire il DB di NAV, BC, la Company e la stringa di connessione");
        return;
      }

      if (runBackgroundWorker.IsBusy)
      {
        MigrationLog.ShowError("Run in corso");
        return;
      }

      try
      {
        SqlController.SetConnectionString(connTextBox.Text);
        SqlController.Connect();
      }
      catch (Exception ex)
      {
        MigrationLog.ShowError("Errore in connessione: " + ex.Message);
        return;
      }

      startTextBox.Text = DateTime.Now.ToString();

      migCtrl.dbNAV = dbNavTextBox.Text;
      migCtrl.dbBC = dbBCTextBox.Text;
      migCtrl.companyForQuery = companiesTextBox.Text;
      migCtrl.runOnlyCompany = onlyCompanyCheckBox.Checked;

      runProgressBar.Maximum = migCtrl.queries.Count;
      runProgressBar.Minimum = 0;
      runProgressBar.Value = 0;
      runProgressBar.Step = 1;
      
      runBackgroundWorker.RunWorkerAsync();
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
          migCtrl.queries[i].Execute(migCtrl.dbNAV, migCtrl.dbBC, migCtrl.companyForQuery, migCtrl.runOnlyCompany);
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
        MigrationLog.Write("CANCELED: " + DateTime.Now.ToString());
      else if (e.Error != null)
        MigrationLog.Write("ERROR: " + e.Error.Message + DateTime.Now.ToString());
      else
        MigrationLog.Write("DONE: " + DateTime.Now.ToString());
    }
  }
}
