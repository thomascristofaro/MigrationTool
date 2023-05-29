
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
      this.loadNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
      this.shrinkStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.logTextBox = new System.Windows.Forms.TextBox();
      this.runProgressBar = new System.Windows.Forms.ProgressBar();
      this.startLabel = new System.Windows.Forms.Label();
      this.startTextBox = new System.Windows.Forms.TextBox();
      this.runBackgroundWorker = new System.ComponentModel.BackgroundWorker();
      this.cancelButton = new System.Windows.Forms.Button();
      this.companyOnRunTextBox = new System.Windows.Forms.TextBox();
      this.compayLabel = new System.Windows.Forms.Label();
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
            this.loadNewToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // loadNewToolStripMenuItem
      // 
      this.loadNewToolStripMenuItem.Name = "loadNewToolStripMenuItem";
      this.loadNewToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
      this.loadNewToolStripMenuItem.Text = "&Load";
      this.loadNewToolStripMenuItem.Click += new System.EventHandler(this.loadNewToolStripMenuItem_Click);
      // 
      // exportToolStripMenuItem
      // 
      this.exportToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
      this.exportToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
      this.exportToolStripMenuItem.Text = "&Export";
      this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
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
      this.setupToolStripMenuItem.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
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
            this.runToolStripMenuItem,
            this.shrinkStripMenuItem});
      this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
      this.toolsToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
      this.toolsToolStripMenuItem.Text = "&Tools";
      // 
      // runToolStripMenuItem
      // 
      this.runToolStripMenuItem.Name = "runToolStripMenuItem";
      this.runToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
      this.runToolStripMenuItem.Text = "&Run";
      this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
      // 
      // shrinkStripMenuItem
      // 
      this.shrinkStripMenuItem.Name = "shrinkStripMenuItem";
      this.shrinkStripMenuItem.Size = new System.Drawing.Size(132, 26);
      this.shrinkStripMenuItem.Text = "&Shrink";
      this.shrinkStripMenuItem.Click += new System.EventHandler(this.shrinkStripMenuItem_Click);
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
      this.statusStrip1.Location = new System.Drawing.Point(0, 381);
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
      // logTextBox
      // 
      this.logTextBox.Location = new System.Drawing.Point(12, 106);
      this.logTextBox.Multiline = true;
      this.logTextBox.Name = "logTextBox";
      this.logTextBox.ReadOnly = true;
      this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.logTextBox.Size = new System.Drawing.Size(776, 266);
      this.logTextBox.TabIndex = 4;
      // 
      // runProgressBar
      // 
      this.runProgressBar.Location = new System.Drawing.Point(12, 71);
      this.runProgressBar.Name = "runProgressBar";
      this.runProgressBar.Size = new System.Drawing.Size(676, 29);
      this.runProgressBar.TabIndex = 5;
      // 
      // startLabel
      // 
      this.startLabel.AutoSize = true;
      this.startLabel.Location = new System.Drawing.Point(12, 41);
      this.startLabel.Name = "startLabel";
      this.startLabel.Size = new System.Drawing.Size(77, 20);
      this.startLabel.TabIndex = 6;
      this.startLabel.Text = "Start Time";
      // 
      // startTextBox
      // 
      this.startTextBox.Location = new System.Drawing.Point(95, 38);
      this.startTextBox.Name = "startTextBox";
      this.startTextBox.ReadOnly = true;
      this.startTextBox.Size = new System.Drawing.Size(200, 27);
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
      // cancelButton
      // 
      this.cancelButton.Location = new System.Drawing.Point(694, 71);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(94, 29);
      this.cancelButton.TabIndex = 8;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // companyOnRunTextBox
      // 
      this.companyOnRunTextBox.Location = new System.Drawing.Point(588, 38);
      this.companyOnRunTextBox.Name = "companyOnRunTextBox";
      this.companyOnRunTextBox.ReadOnly = true;
      this.companyOnRunTextBox.Size = new System.Drawing.Size(200, 27);
      this.companyOnRunTextBox.TabIndex = 10;
      // 
      // compayLabel
      // 
      this.compayLabel.AutoSize = true;
      this.compayLabel.Location = new System.Drawing.Point(510, 41);
      this.compayLabel.Name = "compayLabel";
      this.compayLabel.Size = new System.Drawing.Size(72, 20);
      this.compayLabel.TabIndex = 9;
      this.compayLabel.Text = "Company";
      // 
      // MigrationTool
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 407);
      this.Controls.Add(this.companyOnRunTextBox);
      this.Controls.Add(this.compayLabel);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.startTextBox);
      this.Controls.Add(this.startLabel);
      this.Controls.Add(this.runProgressBar);
      this.Controls.Add(this.logTextBox);
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
    private System.Windows.Forms.TextBox logTextBox;
    private System.Windows.Forms.ProgressBar runProgressBar;
    private System.Windows.Forms.Label startLabel;
    private System.Windows.Forms.TextBox startTextBox;
    private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.ComponentModel.BackgroundWorker runBackgroundWorker;
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.ToolStripMenuItem shrinkStripMenuItem;
    private System.Windows.Forms.TextBox companyOnRunTextBox;
    private System.Windows.Forms.Label compayLabel;
    private System.Windows.Forms.ToolStripMenuItem loadNewToolStripMenuItem;
  }
}

