
namespace MigrationTool
{
  partial class QueryForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.queryDataGridView = new System.Windows.Forms.DataGridView();
      this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Table = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.queryTextBox = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.queryDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // queryDataGridView
      // 
      this.queryDataGridView.AllowUserToAddRows = false;
      this.queryDataGridView.AllowUserToDeleteRows = false;
      this.queryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.queryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Type,
            this.Table,
            this.Company});
      this.queryDataGridView.Location = new System.Drawing.Point(12, 12);
      this.queryDataGridView.Name = "queryDataGridView";
      this.queryDataGridView.RowHeadersWidth = 51;
      this.queryDataGridView.RowTemplate.Height = 29;
      this.queryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.queryDataGridView.Size = new System.Drawing.Size(656, 529);
      this.queryDataGridView.TabIndex = 0;
      this.queryDataGridView.SelectionChanged += new System.EventHandler(this.queryDataGridView_SelectionChanged);
      // 
      // Id
      // 
      this.Id.HeaderText = "Id";
      this.Id.MinimumWidth = 6;
      this.Id.Name = "Id";
      this.Id.ReadOnly = true;
      this.Id.Width = 75;
      // 
      // Type
      // 
      this.Type.HeaderText = "Type";
      this.Type.MinimumWidth = 6;
      this.Type.Name = "Type";
      this.Type.Width = 125;
      // 
      // Table
      // 
      this.Table.HeaderText = "Table";
      this.Table.MinimumWidth = 6;
      this.Table.Name = "Table";
      this.Table.ReadOnly = true;
      this.Table.Width = 250;
      // 
      // Company
      // 
      this.Company.HeaderText = "Company";
      this.Company.MinimumWidth = 6;
      this.Company.Name = "Company";
      this.Company.Width = 125;
      // 
      // queryTextBox
      // 
      this.queryTextBox.Location = new System.Drawing.Point(674, 12);
      this.queryTextBox.Multiline = true;
      this.queryTextBox.Name = "queryTextBox";
      this.queryTextBox.ReadOnly = true;
      this.queryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.queryTextBox.Size = new System.Drawing.Size(796, 529);
      this.queryTextBox.TabIndex = 1;
      // 
      // QueryForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1482, 553);
      this.Controls.Add(this.queryTextBox);
      this.Controls.Add(this.queryDataGridView);
      this.Name = "QueryForm";
      this.Text = "Query";
      this.Load += new System.EventHandler(this.QueryForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.queryDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView queryDataGridView;
    private System.Windows.Forms.TextBox queryTextBox;
    private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    private System.Windows.Forms.DataGridViewTextBoxColumn Type;
    private System.Windows.Forms.DataGridViewTextBoxColumn Table;
    private System.Windows.Forms.DataGridViewTextBoxColumn Company;
  }
}