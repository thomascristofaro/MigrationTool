using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MigrationTool
{
  public partial class SetupForm : Form
  {
    public SetupForm()
    {
      InitializeComponent();
    }

    private void saveSetupBtn_Click(object sender, EventArgs e)
    {
      try
      {
        AppSettingsHelper.SaveToFile();
      }
      catch (Exception ex)
      {
        MigrationLog.ShowError(ex.Message);
      }
     }

    private void SetupForm_Load(object sender, EventArgs e)
    {
      this.connTextBox.Text = AppSettingsHelper.Config.Connection;
      this.companiesTextBox.Text = AppSettingsHelper.Config.Companies;
      this.placeholderCompanyTextBox.Text = AppSettingsHelper.Config.PlaceholderCompany; 
      this.dbBCTextBox.Text = AppSettingsHelper.Config.DBBC; 
      this.dbNavTextBox.Text = AppSettingsHelper.Config.DBNAV; 
      this.placeholderNavTextBox.Text = AppSettingsHelper.Config.PlaceholderDBNAV; 
      this.placeholderBCTextBox.Text = AppSettingsHelper.Config.PlaceholderDBBC; 
      this.tagSplitTextBox.Text = AppSettingsHelper.Config.TagSplit;
      this.logToShrinkTextBox.Text = AppSettingsHelper.Config.LogToShrink;
      this.runOnlyCompanyCheckBox.Checked = AppSettingsHelper.RunQueryOnlyWithCompany;
    }

    private void runOnlyCompanyCheckBox_CheckedChanged(object sender, EventArgs e)
    {
      AppSettingsHelper.RunQueryOnlyWithCompany = runOnlyCompanyCheckBox.Checked;
    }
  }
}
