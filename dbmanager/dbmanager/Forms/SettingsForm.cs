using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbmanager
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            cbAutobackup.CheckedChanged += AutoBackupChanged;
            cbAutoDelete.CheckedChanged += AutoDeleteChanged;
        }



        protected override void OnLoad(EventArgs e)
        {
            LoadSettings();
            AutoBackupChanged(null, null);
            AutoDeleteChanged(null, null);
            base.OnLoad(e);
        }

        private void LoadSettings()
        {
            txtLocation.Text = Properties.Settings.Default.DefaultLocation;
            cbAutobackup.Checked = Properties.Settings.Default.RunAutoBackUp.Equals("1");

            var backupType = Properties.Settings.Default.AutoBackupType;
            switch (backupType)
            {
                case "1":
                    rbHours.Checked = true;
                    break;
                case "2":
                    rbDays.Checked = true;
                    break;
                case "3":
                    rbWeek.Checked = true;
                    break;
            }
            numAutoBackup.Value = decimal.Parse(Properties.Settings.Default.AutoBackupSched);
            cbAutoDelete.Checked = Properties.Settings.Default.RunAutoDelete.Equals("1");
            txtConnectionString.Text = Properties.Settings.Default.ConnectionString;
            txtDatabaseName.Text = Properties.Settings.Default.DefaultDatabaseName;
        }
        private void AutoBackupChanged(object sender, EventArgs e)
        {
            if(cbAutobackup.Checked)
            {
                rbDays.Enabled = rbHours.Enabled = rbWeek.Enabled = numAutoBackup.Enabled = true;
            }
            else
            {
                rbDays.Enabled = rbHours.Enabled = rbWeek.Enabled = numAutoBackup.Enabled = false;
            }
        }
        private void AutoDeleteChanged(object sender, EventArgs e)
        {
            if(cbAutoDelete.Checked)
            {
                numDaysOld.Enabled = true;
            }
            else
            {
                numDaysOld.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save this settings?", this.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveSettings();
            }
        }

        private void SaveSettings()
        {
            if(txtLocation.Text.Length > 0)
            {
                if(!Directory.Exists(txtLocation.Text))
                {
                    MessageBox.Show("Target Directory is not existing.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Properties.Settings.Default.DefaultLocation = txtLocation.Text;
            }
            if(cbAutobackup.Checked)
            {
                Properties.Settings.Default.RunAutoBackUp = "1";
            }
            else
            {
                Properties.Settings.Default.RunAutoBackUp = "0";
            }
            if (rbHours.Checked)
                Properties.Settings.Default.AutoBackupType = "1";
            if (rbDays.Checked)
                Properties.Settings.Default.AutoBackupType = "2";
            if (rbWeek.Checked)
                Properties.Settings.Default.AutoBackupType = "3";
            if (cbAutoDelete.Checked)
                Properties.Settings.Default.RunAutoDelete = "1";
            else
                Properties.Settings.Default.RunAutoDelete = "0";

            Properties.Settings.Default.AutoBackupSched = numAutoBackup.Value.ToString();
            Properties.Settings.Default.AutoDeleteDaysOld = numDaysOld.Value.ToString();
            if(TestConnectionString(false))
                Properties.Settings.Default.ConnectionString = txtConnectionString.Text;
            else
            {
                MessageBox.Show("Cannot connect to database. Please check your connection string.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(CheckDatabaseName() == false)
            {
                MessageBox.Show("Cannot connect to database. Please check your database name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Properties.Settings.Default.DefaultDatabaseName = txtDatabaseName.Text;
            }

            Properties.Settings.Default.Save();
            MessageBox.Show("Process has been successfully completed.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool CheckDatabaseName()
        {
            bool isExist = false;
            var db = txtDatabaseName.Text.Replace(" ", "").ToLower();
            if(TestConnectionString(false))
            { 
                var sql = "SELECT [d].[name] FROM  [sys].[databases] [d] WHERE [d].[database_id] > 4";
                var result = DatabaseHelper.LoadDataTable(sql, txtConnectionString.Text);

                foreach(DataRow dr in result.Rows)
                {
                    if (dr["name"].ToString().ToLower().Equals(db))
                    {
                        isExist = true;
                        break;
                    }
                }
            }
            return isExist;
        }
        bool TestConnectionString(bool showSuccess = false)
        {
            bool isCorrect = false;
            if (txtConnectionString.Text.Length > 0)
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = txtConnectionString.Text;
                try
                {
                    cn.Open();
                    isCorrect = true;
                    if(showSuccess)
                    {
                        MessageBox.Show("Connecting to database succeeded!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot connect to database. Please check your connection string.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isCorrect = false;
                }
                finally
                {
                    if (cn.State == ConnectionState.Open)
                        cn.Close();
                }
            }
            return isCorrect;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to restore settings to default?",this.Text,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Properties.Settings.Default.Reset();
                Properties.Settings.Default.Save();
                MessageBox.Show("Database management settings restored to default.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSettings();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtLocation.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
