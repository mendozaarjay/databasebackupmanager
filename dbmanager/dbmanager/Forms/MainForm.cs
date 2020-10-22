using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace dbmanager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            this.DoubleBuffered = true;
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            cbBackup_CheckedChanged(null, null);
            cbDelete_CheckedChanged(null, null);
            ShowSettings();
            RefreshBackupList();
            LoadSystemLogs();
            base.OnLoad(e);
        }

        private void ShowSettings()
        {
            txtDatabase.Text = Properties.Settings.Default.DefaultDatabaseName;
            txtLocation.Text = Properties.Settings.Default.DefaultLocation;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm frm = new SettingsForm();
            frm.ShowDialog();
            ShowSettings();
        }
        public void ShowBackUpStatus(bool isCompleted,string error ="")
        {
            if (isCompleted)
            {
                lblStatus.Text = "Database back up successfully completed.";
            }
            else
            {
                lblStatus.Text = error;
            }
        }
        public void RefreshBackupList()
        {
            dgList.Rows.Clear();
            if(!Directory.Exists(Properties.Settings.Default.DefaultLocation))
            {
                Properties.Settings.Default.DefaultLocation = string.Empty;
                SaveProperties();
                txtLocation.Text = string.Empty;
                return;
            }

            DirectoryInfo info = new DirectoryInfo(Properties.Settings.Default.DefaultLocation);
            FileInfo[] files = info.GetFiles("*.bak");
            var result = files.OrderByDescending(a => a.LastWriteTime);
            foreach(var item in result)
            {
                dgList.Rows.Add(1);
                var row = dgList.Rows.Count - 1;

                dgList[dtlFilename.Index, row].Value = item.Name;
                dgList[dtlCreationDate.Index, row].Value = item.LastWriteTime;
                dgList[dtlSize.Index, row].Value = (item.Length / 1024).ToString() + " KB";
                TimeSpan timeSpan =   DateTime.Now - item.LastWriteTime;

                dgList[dtlOld.Index, row].Value = (int) timeSpan.TotalDays;
            }

        }

        public void LoadSystemLogs()
        {
            dgLogs.Rows.Clear();
            var path = Path.Combine(Application.StartupPath, "SystemLogs");
            DirectoryInfo info = new DirectoryInfo(path);
            FileInfo[] files = info.GetFiles("*.xml");
            var result = files.OrderByDescending(a => a.LastWriteTime);
            int row = 0;
            foreach(var item in result)
            {
                dgLogs.Rows.Add(1);
                XmlDocument xml = new XmlDocument();
                xml.Load(item.FullName);
                XmlNodeList nodes = xml.DocumentElement.SelectNodes("/SystemLog");
                foreach(XmlNode node in nodes)
                {
                    dgLogs[dtlMethod.Index, row].Value = node.SelectSingleNode("Method").InnerText;
                    dgLogs[dtlDatabase.Index, row].Value = node.SelectSingleNode("Database").InnerText;
                    dgLogs[dtlOperation.Index, row].Value = node.SelectSingleNode("OperationType").InnerText;
                    dgLogs[dtlOperationTime.Index, row].Value = node.SelectSingleNode("OperationTime").InnerText;
                    dgLogs[dtlIsSuccess.Index, row].Value = node.SelectSingleNode("IsSuccess").InnerText;
                    dgLogs[dtlRemarks.Index, row].Value = node.SelectSingleNode("SystemRemarks").InnerText;
                };
                row++;
            };
        }

        private async void btnBackup_Click(object sender, EventArgs e)
        {

            BackupService services = new BackupService();

            this.Enabled = false;
            lblStatus.Text = "Please wait while that back up process is ongoing...";
            if (!Directory.Exists(Properties.Settings.Default.DefaultLocation))
            {
                MessageBox.Show("Cannot Continue. Kindly check your default back up location.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = true;
                lblStatus.Text = "Cannot find default database location.";
                RefreshBackupList();
                LoadSystemLogs();
                return;
            }
            if (!services.IsConnected())
            {
                MessageBox.Show("Cannot Continue. Kindly check your connection string.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = true;
                lblStatus.Text = "Cannot access default connection string.";
                RefreshBackupList();
                return;
            }
            if (!services.IsDatabaseExist())
            {
                MessageBox.Show("Cannot Continue. Kindly check your default database name.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Enabled = true;
                lblStatus.Text = "Cannot access default database name.";
                RefreshBackupList();
                LoadSystemLogs();
                return;
            }

            services.MainForm = this;
            services.Method = "Manual Backup";
            services.OperationType = "Backup";
            await services.BackupDatabaseAsync();
            this.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshBackupList();
            LoadSystemLogs();
            lblStatus.Text = "Ready";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!cbDelete.Checked && !cbBackup.Checked)
                return;

            btnBackup.Enabled = false;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnSettings.Enabled = btnRefresh.Enabled = false;

            if (cbBackup.Checked)
            {
                if (Properties.Settings.Default.LastBackup.Length <= 0)
                    Properties.Settings.Default.LastBackup = DateTime.Now.ToString();

                if (Properties.Settings.Default.RunAutoBackUp.Equals("1"))
                {
                    tmAutoBackup.Enabled = true;
                    SaveProperties();
                    SetNextBackUp();
                    UpdateAutoBackupLabels();
                }
                else
                {
                    MessageBox.Show("Cannot Continue. Please check if auto back up is enabled in the settings.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
            }
            if (cbDelete.Checked)
            {
                if (Properties.Settings.Default.LastDelete.Length <= 0)
                    Properties.Settings.Default.LastDelete = DateTime.Now.ToString();

                if (Properties.Settings.Default.RunAutoDelete.Equals("1"))
                {
                    tmAutoDelete.Enabled = true;
                    SaveProperties();
                    SetNextDelete();
                    UpdateAutoDeleteLabels();
                }
                else
                {
                    MessageBox.Show("Cannot Continue. Please check if auto delete up is enabled in the settings.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            cbBackup.Enabled = cbDelete.Enabled = false;
        }

        private void UpdateAutoDeleteLabels()
        {
            try
            {
                lblLastAutoDelete.Text = "Last Delete : " + DateTime.Parse(Properties.Settings.Default.LastDelete).ToString("MM/dd/yyyy hh:mm tt");
                lblNextAutoDelete.Text = "Next Delete : " + DateTime.Parse(Properties.Settings.Default.NextDelete).ToString("MM/dd/yyyy hh:mm tt");
            }
            catch (Exception ex)
            {

            }
        }

        private void SetNextDelete()
        {
            DateTime next = new DateTime();
            var last = DateTime.Parse(Properties.Settings.Default.LastDelete);
            var toAdd = double.Parse(Properties.Settings.Default.AutoDeleteDaysOld);

            next = last.AddDays(toAdd);

            Properties.Settings.Default.NextDelete = next.ToString();

            SaveProperties();
        }

        async Task AutoBackUp()
        {
            this.Enabled = false;
            lblStatus.Text = "Please wait while that back up process is ongoing...";
            BackupService services = new BackupService();
            services.MainForm = this;
            services.Method = "Auto Backup";
            services.OperationType = "Backup";
            await services.BackupDatabaseAsync();
            this.Enabled = true;
        }
        void SaveProperties()
        {
            Properties.Settings.Default.Save();
        }

        private async void tmAutoBackup_Tick(object sender, EventArgs e)
        {
            var _last = DateTime.Parse(Properties.Settings.Default.LastBackup).ToString("MM/dd/yyyy hh:mm tt");
            var _next = DateTime.Parse(Properties.Settings.Default.NextBackup).ToString("MM/dd/yyyy hh:mm tt");
            var now = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            if (_next.Equals(now))
            {
                Properties.Settings.Default.LastBackup = DateTime.Now.ToString();
                SaveProperties();
                SetNextBackUp();
                UpdateAutoBackupLabels();
                await AutoBackUp();
            }
        }
        private void tmAutoDelete_Tick(object sender, EventArgs e)
        {
            var _last = DateTime.Parse(Properties.Settings.Default.LastDelete).ToString("MM/dd/yyyy hh:mm tt");
            var _next = DateTime.Parse(Properties.Settings.Default.NextDelete).ToString("MM/dd/yyyy hh:mm tt");
            var now = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            if (_next.Equals(now))
            {
                Properties.Settings.Default.LastDelete = DateTime.Now.ToString();
                SaveProperties();
                SetNextDelete();
                UpdateAutoDeleteLabels();
                DeleteOldBackUps();
            }
        }

        private void DeleteOldBackUps()
        {
            lblStatus.Text = "Deleting old database back ups.";
            DirectoryInfo info = new DirectoryInfo(Properties.Settings.Default.DefaultLocation);
            FileInfo[] files = info.GetFiles("*.bak");
            var old = double.Parse(Properties.Settings.Default.AutoDeleteDaysOld);
            var result = files.Where(a => (DateTime.Now - a.LastWriteTime).TotalDays >= old);
            foreach(var item in result)
            {
                try
                {
                    File.Delete(item.FullName);
                    var log = new LoggerModel
                    {
                        Method = "Delete",
                        Database = item.Name,
                        IsSuccess = "True",
                        OperationTime = DateTime.Now.ToString(),
                        OperationType = "Auto Delete",
                        SystemRemarks = "Process has been successsfully completed."
                    };
                    SystemLogger.Log(log);
                }
                catch (Exception ex)
                {
                    var log = new LoggerModel
                    {
                        Method = "Delete",
                        Database = item.Name,
                        IsSuccess = "False",
                        OperationTime = DateTime.Now.ToString(),
                        OperationType = "Auto Delete",
                        SystemRemarks = ex.Message
                    };
                    SystemLogger.Log(log);

                }
            }
            lblStatus.Text = "Deleting old successfully completed.";
            RefreshBackupList();
            LoadSystemLogs();
        }

        private void SetNextBackUp()
        {
            DateTime next = new DateTime();
            var last = DateTime.Parse(Properties.Settings.Default.LastBackup);
            var toAdd = double.Parse(Properties.Settings.Default.AutoBackupSched);
            var backupType = Properties.Settings.Default.AutoBackupType;
            switch (backupType)
            {
                case "1":
                    next = last.AddHours(toAdd);
                    break;
                case "2":
                    next = last.AddDays(toAdd);
                    break;
                case "3":
                    next = last.AddDays(toAdd * 7);
                    break;
                case "4":
                    next = last.AddMinutes(toAdd);
                    break;
            }

            Properties.Settings.Default.NextBackup = next.ToString();

            SaveProperties();
        }
        void UpdateAutoBackupLabels()
        {
            try
            {
                lblLastAutoBackup.Text = "Last Backup : " + DateTime.Parse(Properties.Settings.Default.LastBackup).ToString("MM/dd/yyyy hh:mm tt");
                lblNextAutoBackUp.Text = "Next Backup : " + DateTime.Parse(Properties.Settings.Default.NextBackup).ToString("MM/dd/yyyy hh:mm tt");
            }
            catch
            {

            }
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            tmAutoBackup.Enabled = false;
            tmAutoDelete.Enabled = false;
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            btnBackup.Enabled = true;
            cbBackup.Enabled = cbDelete.Enabled = true;
            btnSettings.Enabled = btnRefresh.Enabled = true;

            
        }

        private void cbBackup_CheckedChanged(object sender, EventArgs e)
        {
            lblLastAutoBackup.Visible = lblNextAutoBackUp.Visible = cbBackup.Checked;
            UpdateAutoBackupLabels();
            if (cbBackup.Checked || cbDelete.Checked)
            {
                btnStart.Enabled = true;
            }
            else
            {
                btnStart.Enabled = false;
            }
        }

        private void cbDelete_CheckedChanged(object sender, EventArgs e)
        {
            lblLastAutoDelete.Visible = lblNextAutoDelete.Visible = cbDelete.Checked;
            UpdateAutoDeleteLabels();
            if(cbBackup.Checked || cbDelete.Checked)
            {
                btnStart.Enabled = true;
            }
            else
            {
                btnStart.Enabled = false;
            }
        }

        private void dgList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if(e.ColumnIndex == dtlDelete.Index)
            {
                var file = dgList[dtlFilename.Index, e.RowIndex].Value.ToString();
                var filename = Path.Combine(Properties.Settings.Default.DefaultLocation, file);
                if(MessageBox.Show("Are you sure you want to delete this backup file?",this.Text,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DeleteFile(filename,file);
                }
            }
        }

        private void DeleteFile(string filename,string file)
        {
            lblStatus.Text = "Deleting database file.";
            try
            {
                File.Delete(filename);
                var log = new LoggerModel
                {
                    Method = "Delete",
                    Database = file,
                    IsSuccess = "True",
                    OperationTime = DateTime.Now.ToString(),
                    OperationType = "Manual Delete",
                    SystemRemarks = "Process has been successsfully completed."
                };
                SystemLogger.Log(log);
                lblStatus.Text = "Deleting database file successfully completed.";
            }
            catch (Exception ex)
            {
                var log = new LoggerModel
                {
                    Method = "Delete",
                    Database = file,
                    IsSuccess = "False",
                    OperationTime = DateTime.Now.ToString(),
                    OperationType = "Manual Delete",
                    SystemRemarks = ex.Message
                };
                SystemLogger.Log(log);
                lblStatus.Text = "Deleting database failed.";
            }
            RefreshBackupList();
            LoadSystemLogs();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowInTaskbar = true;
            notifyIcon.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }
        protected override void OnResize(EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(2000);
                this.ShowInTaskbar = false;
            }
            base.OnResize(e);
        }
    }
}
