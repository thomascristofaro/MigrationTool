
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
      this.cancelButton = new System.Windows.Forms.Button();
      this.dbNavLabel = new System.Windows.Forms.Label();
      this.dbBCLabel = new System.Windows.Forms.Label();
      this.CompaniesLabel = new System.Windows.Forms.Label();
      this.dbNavTextBox = new System.Windows.Forms.TextBox();
      this.dbBCTextBox = new System.Windows.Forms.TextBox();
      this.companiesTextBox = new System.Windows.Forms.TextBox();
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
      this.statusStrip1.Location = new System.Drawing.Point(0, 491);
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
      this.migFileLabel.Location = new System.Drawing.Point(12, 54);
      this.migFileLabel.Name = "migFileLabel";
      this.migFileLabel.Size = new System.Drawing.Size(101, 20);
      this.migFileLabel.TabIndex = 2;
      this.migFileLabel.Text = "Migration File";
      // 
      // migFileTextBox
      // 
      this.migFileTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.migFileTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
      this.migFileTextBox.Location = new System.Drawing.Point(119, 51);
      this.migFileTextBox.Name = "migFileTextBox";
      this.migFileTextBox.ReadOnly = true;
      this.migFileTextBox.Size = new System.Drawing.Size(200, 27);
      this.migFileTextBox.TabIndex = 3;
      this.migFileTextBox.Text = "Not Loaded";
      // 
      // logTextBox
      // 
      this.logTextBox.Location = new System.Drawing.Point(12, 222);
      this.logTextBox.Multiline = true;
      this.logTextBox.Name = "logTextBox";
      this.logTextBox.ReadOnly = true;
      this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.logTextBox.Size = new System.Drawing.Size(776, 266);
      this.logTextBox.TabIndex = 4;
      // 
      // runProgressBar
      // 
      this.runProgressBar.Location = new System.Drawing.Point(12, 187);
      this.runProgressBar.Name = "runProgressBar";
      this.runProgressBar.Size = new System.Drawing.Size(676, 29);
      this.runProgressBar.TabIndex = 5;
      // 
      // startLabel
      // 
      this.startLabel.AutoSize = true;
      this.startLabel.Location = new System.Drawing.Point(12, 100);
      this.startLabel.Name = "startLabel";
      this.startLabel.Size = new System.Drawing.Size(77, 20);
      this.startLabel.TabIndex = 6;
      this.startLabel.Text = "Start Time";
      // 
      // startTextBox
      // 
      this.startTextBox.Location = new System.Drawing.Point(119, 97);
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
      this.cancelButton.Location = new System.Drawing.Point(694, 187);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(94, 29);
      this.cancelButton.TabIndex = 8;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // dbNavLabel
      // 
      this.dbNavLabel.AutoSize = true;
      this.dbNavLabel.Location = new System.Drawing.Point(383, 54);
      this.dbNavLabel.Name = "dbNavLabel";
      this.dbNavLabel.Size = new System.Drawing.Size(62, 20);
      this.dbNavLabel.TabIndex = 9;
      this.dbNavLabel.Text = "DB NAV";
      // 
      // dbBCLabel
      // 
      this.dbBCLabel.AutoSize = true;
      this.dbBCLabel.Location = new System.Drawing.Point(383, 100);
      this.dbBCLabel.Name = "dbBCLabel";
      this.dbBCLabel.Size = new System.Drawing.Size(51, 20);
      this.dbBCLabel.TabIndex = 10;
      this.dbBCLabel.Text = "DB BC";
      // 
      // CompaniesLabel
      // 
      this.CompaniesLabel.AutoSize = true;
      this.CompaniesLabel.Location = new System.Drawing.Point(12, 144);
      this.CompaniesLabel.Name = "CompaniesLabel";
      this.CompaniesLabel.Size = new System.Drawing.Size(83, 20);
      this.CompaniesLabel.TabIndex = 11;
      this.CompaniesLabel.Text = "Companies";
      // 
      // dbNavTextBox
      // 
      this.dbNavTextBox.Location = new System.Drawing.Point(451, 51);
      this.dbNavTextBox.Name = "dbNavTextBox";
      this.dbNavTextBox.Size = new System.Drawing.Size(200, 27);
      this.dbNavTextBox.TabIndex = 12;
      // 
      // dbBCTextBox
      // 
      this.dbBCTextBox.Location = new System.Drawing.Point(451, 97);
      this.dbBCTextBox.Name = "dbBCTextBox";
      this.dbBCTextBox.Size = new System.Drawing.Size(200, 27);
      this.dbBCTextBox.TabIndex = 13;
      // 
      // companiesTextBox
      // 
      this.companiesTextBox.Location = new System.Drawing.Point(119, 141);
      this.companiesTextBox.Name = "companiesTextBox";
      this.companiesTextBox.Size = new System.Drawing.Size(532, 27);
      this.companiesTextBox.TabIndex = 14;
      // 
      // MigrationTool
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 517);
      this.Controls.Add(this.companiesTextBox);
      this.Controls.Add(this.dbBCTextBox);
      this.Controls.Add(this.dbNavTextBox);
      this.Controls.Add(this.CompaniesLabel);
      this.Controls.Add(this.dbBCLabel);
      this.Controls.Add(this.dbNavLabel);
      this.Controls.Add(this.cancelButton);
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
    private System.Windows.Forms.Button cancelButton;
    private System.Windows.Forms.Label dbNavLabel;
    private System.Windows.Forms.Label dbBCLabel;
    private System.Windows.Forms.Label CompaniesLabel;
    private System.Windows.Forms.TextBox dbNavTextBox;
    private System.Windows.Forms.TextBox dbBCTextBox;
    private System.Windows.Forms.TextBox companiesTextBox;
  }
}

