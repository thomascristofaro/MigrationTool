using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MigrationTool
{
  class MigrationLog
  {
    private delegate void WriteLog(string text);
    private static TextBox logTextBox = null;

    public static void SetTextBox(TextBox formTextBox)
    {
      logTextBox = formTextBox;
    }

    public static void Write(string text)
    {
      System.Threading.Thread thread = new System.Threading.Thread(() =>
      {
        if (logTextBox.InvokeRequired)
          logTextBox.Invoke(new WriteLog(AppendToTextBox), text);
        else
          AppendToTextBox(text);
      });
      thread.Start();
    }

    private static void AppendToTextBox(string text)
    {
      logTextBox.AppendText(text);
      logTextBox.AppendText(Environment.NewLine);
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
