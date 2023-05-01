using System;
using System.Collections.Generic;
using System.Text;

namespace MigrationTool
{
  class MigrationLog
  {
    private delegate void WriteLog(string text);
    private static System.Windows.Forms.TextBox logTextBox = null;

    public static void SetTextBox(System.Windows.Forms.TextBox formTextBox)
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
  }
}
