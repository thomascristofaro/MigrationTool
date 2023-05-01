
namespace MigrationTool
{
  partial class MigrationTool
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.clearLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.migFileLabel = new System.Windows.Forms.Label();
      this.migFileTextBox = new System.Windows.Forms.TextBox();
      this.logTextBox = new System.Windows.Forms.TextBox();
      this.runProgressBar = new System.Windows.Forms.ProgressBar();
      this.startLabel = new System.Windows.Forms.Label();
      this.startTextBox = new System.Windows.Forms.TextBox();
      this.runBackgroundWorker = new System.ComponentModel.BackgroundWorker();
      this.menuStrip1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 28);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
      this.fileToolStripMenuItem.Text = "&File";
      this.fileToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.fileToolStripMenuItem_DropDownItemClicked);
      // 
      // loadToolStripMenuItem
      // 
      this.loadToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
      this.loadToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
      this.loadToolStripMenuItem.Text = "&Load";
      this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
      // 
      // exportToolStripMenuItem
      // 
      this.exportToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
      this.exportToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
      this.exportToolStripMenuItem.Text = "&Export";
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(132, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
      this.exitToolStripMenuItem.Text = "E&xit";
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.toolStripSeparator1,
            this.clearLogToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
      this.editToolStripMenuItem.Text = "&Edit";
      // 
      // queryToolStripMenuItem
      // 
      this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
      this.queryToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
      this.queryToolStripMenuItem.Text = "&Query";
      this.queryToolStripMenuItem.Click += new System.EventHandler(this.queryToolStripMenuItem_Click);
      // 
      // setupToolStripMenuItem
      // 
      this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
      this.setupToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
      this.setupToolStripMenuItem.Text = "&Setup";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
      // 
      // clearLogToolStripMenuItem
      // 
      this.clearLogToolStripMenuItem.Name = "clearLogToolStripMenuItem";
      this.clearLogToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
      this.clearLogToolStripMenuItem.Text = "Clear &Log";
      this.clearLogToolStripMenuItem.Click += new System.EventHandler(this.clearLogToolStripMenuItem_Click);
      // 
      // toolsToolStripMenuItem
      // 
      this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem});
      this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
      this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
      this.toolsToolStripMenuItem.Text = "&Tools";
      // 
      // runToolStripMenuItem
      // 
      this.runToolStripMenuItem.Name = "runToolStripMenuItem";
      this.runToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
      this.runToolStripMenuItem.Text = "&Run";
      this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
      this.aboutToolStripMenuItem.Text = "&About...";
      // 
      // statusStrip1
      // 
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
      this.statusStrip1.Location = new System.Drawing.Point(0, 411);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(800, 26);
      this.statusStrip1.TabIndex = 1;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
      this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
      // 
      // migFileLabel
      // 
      this.migFileLabel.AutoSize = true;
      this.migFileLabel.Location = new System.Drawing.Point(12, 49);
      this.migFileLabel.Name = "migFileLabel";
      this.migFileLabel.Size = new System.Drawing.Size(101, 20);
      this.migFileLabel.TabIndex = 2;
      this.migFileLabel.Text = "Migration File";
      // 
      // migFileTextBox
      // 
      this.migFileTextBox.Enabled = false;
      this.migFileTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.migFileTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
      this.migFileTextBox.Location = new System.Drawing.Point(119, 46);
      this.migFileTextBox.Name = "migFileTextBox";
      this.migFileTextBox.ReadOnly = true;
      this.migFileTextBox.Size = new System.Drawing.Size(125, 27);
      this.migFileTextBox.TabIndex = 3;
      this.migFileTextBox.Text = "Not Loaded";
      // 
      // logTextBox
      // 
      this.logTextBox.Location = new System.Drawing.Point(12, 142);
      this.logTextBox.Multiline = true;
      this.logTextBox.Name = "logTextBox";
      this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.logTextBox.Size = new System.Drawing.Size(776, 266);
      this.logTextBox.TabIndex = 4;
      // 
      // runProgressBar
      // 
      this.runProgressBar.Location = new System.Drawing.Point(12, 107);
      this.runProgressBar.Name = "runProgressBar";
      this.runProgressBar.Size = new System.Drawing.Size(776, 29);
      this.runProgressBar.TabIndex = 5;
      // 
      // startLabel
      // 
      this.startLabel.AutoSize = true;
      this.startLabel.Location = new System.Drawing.Point(326, 49);
      this.startLabel.Name = "startLabel";
      this.startLabel.Size = new System.Drawing.Size(77, 20);
      this.startLabel.TabIndex = 6;
      this.startLabel.Text = "Start Time";
      // 
      // startTextBox
      // 
      this.startTextBox.Enabled = false;
      this.startTextBox.Location = new System.Drawing.Point(409, 46);
      this.startTextBox.Name = "startTextBox";
      this.startTextBox.ReadOnly = true;
      this.startTextBox.Size = new System.Drawing.Size(125, 27);
      this.startTextBox.TabIndex = 7;
      // 
      // runBackgroundWorker
      // 
      this.runBackgroundWorker.WorkerReportsProgress = true;
      this.runBackgroundWorker.WorkerSupportsCancellation = true;
      this.runBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.runBackgroundWorker_DoWork);
      this.runBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.runBackgroundWorker_ProgressChanged);
      this.runBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.runBackgroundWorker_RunWorkerCompleted);
      // 
      // MigrationTool
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 437);
      this.Controls.Add(this.startTextBox);
      this.Controls.Add(this.startLabel);
      this.Controls.Add(this.runProgressBar);
      this.Controls.Add(this.logTextBox);
      this.Controls.Add(this.migFileTextBox);
      this.Controls.Add(this.migFileLabel);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MigrationTool";
      this.Text = "MigrationTool";
      this.Load += new System.EventHandler(this.MigrationTool_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.Label migFileLabel;
    private System.Windows.Forms.TextBox migFileTextBox;
    private System.Windows.Forms.TextBox logTextBox;
    private System.Windows.Forms.ProgressBar runProgressBar;
    private System.Windows.Forms.Label startLabel;
    private System.Windows.Forms.TextBox startTextBox;
    private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.ComponentModel.BackgroundWorker runBackgroundWorker;
  }
}

