using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MigrationTool
{
  public partial class QueryForm : Form
  {
    private MigrationController migCtrl;
    public QueryForm(MigrationController ctrl)
    {
      InitializeComponent();
      this.migCtrl = ctrl;
    }

    private void QueryForm_Load(object sender, EventArgs e)
    {
      foreach (var query in migCtrl.queries)
      {
        queryDataGridView.Rows.Add(new object[] { query.id.ToString(), query.type.ToString(), query.table, query.company});
      }
    }

    private void queryDataGridView_SelectionChanged(object sender, EventArgs e)
    {
      if (queryDataGridView.SelectedRows.Count > 0)
      {
        var query = migCtrl.queries[queryDataGridView.SelectedRows[0].Index];
        queryTextBox.Text = query.query;
      }
    }
  }
}
