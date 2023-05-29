using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MigrationTool
{
  class MigrationLog
  {
    private delegate void WriteLog(string text);
    public static TextBox logTextBox { get; set; }
    public static string fileName { get; set; }

    public static void Write(string text)
    {
      System.Threading.Thread thread = new System.Threading.Thread(() =>
      {
        if (logTextBox.InvokeRequired)
          logTextBox.Invoke(new WriteLog(AppendToTextBox), text);
        else
          AppendToTextBox(text);
        AppendToFile(text);
      });
      thread.Start();
    }

    private static void AppendToTextBox(string text)
    {
      logTextBox.AppendText(text);
      logTextBox.AppendText(Environment.NewLine);
    }
    private static void AppendToFile(string text)
    {
      if (!String.IsNullOrEmpty(fileName))
        File.AppendAllText(fileName, text + Environment.NewLine);
    }

    public static void Clear()
    {
      logTextBox.Clear();
    }

    public static void ShowError(string message)
    {
      MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    public static void ShowMessage(string message)
    {
      MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
