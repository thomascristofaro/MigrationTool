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

    private void UpdateStatus(string item)
    {
      if (item != null)
      {
        string msg = String.Format("{0} selected", item);
        this.statusStrip1.Items[0].Text = msg;
      }
    }

    private void fileToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
    {
      this.UpdateStatus(e.ClickedItem.Text);
    }

    private void loadToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileDialog open = new OpenFileDialog();
      open.Filter = "Sql|*.sql";
      if (open.ShowDialog() == DialogResult.OK)
      {
        migCtrl.LoadMigrationFile(open.FileName);
        migFileTextBox.Text = "Loaded";
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
        MessageBox.Show("File non caricato!", "ERRORE");
        return;
      }

      runProgressBar.Maximum = migCtrl.queries.Count;
      runProgressBar.Minimum = 0;
      runProgressBar.Step = 1;

      if (runBackgroundWorker.IsBusy != true)
        runBackgroundWorker.RunWorkerAsync();
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
          migCtrl.queries[i].Run();
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
      if (e.Cancelled == true)
      {
        UpdateStatus("Canceled!");
      }
      else if (e.Error != null)
      {
        UpdateStatus("Error: " + e.Error.Message);
      }
      else
      {
        UpdateStatus("Done!");
      }

    }
  }
}
