namespace dbmanager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnSettings = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.dtlFilename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlOld = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnRefresh = new System.Windows.Forms.PictureBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.cbBackup = new System.Windows.Forms.CheckBox();
            this.tmAutoBackup = new System.Windows.Forms.Timer(this.components);
            this.pnlAuto = new System.Windows.Forms.Panel();
            this.lblNextAutoDelete = new System.Windows.Forms.Label();
            this.lblLastAutoDelete = new System.Windows.Forms.Label();
            this.lblNextAutoBackUp = new System.Windows.Forms.Label();
            this.lblLastAutoBackup = new System.Windows.Forms.Label();
            this.tmAutoDelete = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgLogs = new System.Windows.Forms.DataGridView();
            this.dtlMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlDatabase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlOperationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlIsSuccess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlAuto.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(1001, 17);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(49, 44);
            this.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSettings.TabIndex = 0;
            this.btnSettings.TabStop = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 685);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1062, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 20);
            this.toolStripStatusLabel1.Text = "Status : ";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 20);
            this.lblStatus.Text = "Ready";
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.AllowUserToDeleteRows = false;
            this.dgList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtlFilename,
            this.dtlCreationDate,
            this.dtlSize,
            this.dtlOld,
            this.dtlDelete});
            this.dgList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgList.Location = new System.Drawing.Point(3, 3);
            this.dgList.Name = "dgList";
            this.dgList.ReadOnly = true;
            this.dgList.RowHeadersWidth = 51;
            this.dgList.RowTemplate.Height = 24;
            this.dgList.Size = new System.Drawing.Size(1048, 431);
            this.dgList.TabIndex = 2;
            this.dgList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgList_CellContentClick);
            // 
            // dtlFilename
            // 
            this.dtlFilename.HeaderText = "File Name";
            this.dtlFilename.MinimumWidth = 6;
            this.dtlFilename.Name = "dtlFilename";
            this.dtlFilename.ReadOnly = true;
            this.dtlFilename.Width = 450;
            // 
            // dtlCreationDate
            // 
            this.dtlCreationDate.HeaderText = "Creation Date";
            this.dtlCreationDate.MinimumWidth = 6;
            this.dtlCreationDate.Name = "dtlCreationDate";
            this.dtlCreationDate.ReadOnly = true;
            this.dtlCreationDate.Width = 200;
            // 
            // dtlSize
            // 
            this.dtlSize.HeaderText = "Size";
            this.dtlSize.MinimumWidth = 6;
            this.dtlSize.Name = "dtlSize";
            this.dtlSize.ReadOnly = true;
            this.dtlSize.Width = 125;
            // 
            // dtlOld
            // 
            this.dtlOld.HeaderText = "Age(days)";
            this.dtlOld.MinimumWidth = 6;
            this.dtlOld.Name = "dtlOld";
            this.dtlOld.ReadOnly = true;
            this.dtlOld.Width = 125;
            // 
            // dtlDelete
            // 
            this.dtlDelete.HeaderText = "Delete";
            this.dtlDelete.MinimumWidth = 6;
            this.dtlDelete.Name = "dtlDelete";
            this.dtlDelete.ReadOnly = true;
            this.dtlDelete.Width = 125;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(1001, 70);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(49, 44);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackup.Location = new System.Drawing.Point(20, 26);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(147, 82);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Backup Now!";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Targe Location";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(161, 135);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.ReadOnly = true;
            this.txtDatabase.Size = new System.Drawing.Size(887, 30);
            this.txtDatabase.TabIndex = 2;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(161, 173);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.ReadOnly = true;
            this.txtLocation.Size = new System.Drawing.Size(887, 30);
            this.txtLocation.TabIndex = 3;
            // 
            // btnStart
            // 
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(190, 20);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 38);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(190, 64);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(130, 38);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDelete);
            this.groupBox1.Controls.Add(this.cbBackup);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Location = new System.Drawing.Point(655, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 108);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Run Automatically";
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(21, 63);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(123, 27);
            this.cbDelete.TabIndex = 9;
            this.cbDelete.Text = "Auto Delete";
            this.cbDelete.UseVisualStyleBackColor = true;
            this.cbDelete.CheckedChanged += new System.EventHandler(this.cbDelete_CheckedChanged);
            // 
            // cbBackup
            // 
            this.cbBackup.AutoSize = true;
            this.cbBackup.Location = new System.Drawing.Point(21, 30);
            this.cbBackup.Name = "cbBackup";
            this.cbBackup.Size = new System.Drawing.Size(129, 27);
            this.cbBackup.TabIndex = 8;
            this.cbBackup.Text = "Auto Backup";
            this.cbBackup.UseVisualStyleBackColor = true;
            this.cbBackup.CheckedChanged += new System.EventHandler(this.cbBackup_CheckedChanged);
            // 
            // tmAutoBackup
            // 
            this.tmAutoBackup.Interval = 1000;
            this.tmAutoBackup.Tick += new System.EventHandler(this.tmAutoBackup_Tick);
            // 
            // pnlAuto
            // 
            this.pnlAuto.Controls.Add(this.lblNextAutoDelete);
            this.pnlAuto.Controls.Add(this.lblLastAutoDelete);
            this.pnlAuto.Controls.Add(this.lblNextAutoBackUp);
            this.pnlAuto.Controls.Add(this.lblLastAutoBackup);
            this.pnlAuto.Location = new System.Drawing.Point(195, 17);
            this.pnlAuto.Name = "pnlAuto";
            this.pnlAuto.Size = new System.Drawing.Size(454, 112);
            this.pnlAuto.TabIndex = 9;
            // 
            // lblNextAutoDelete
            // 
            this.lblNextAutoDelete.AutoSize = true;
            this.lblNextAutoDelete.Location = new System.Drawing.Point(14, 76);
            this.lblNextAutoDelete.Name = "lblNextAutoDelete";
            this.lblNextAutoDelete.Size = new System.Drawing.Size(109, 23);
            this.lblNextAutoDelete.TabIndex = 3;
            this.lblNextAutoDelete.Text = "Next Delete :";
            // 
            // lblLastAutoDelete
            // 
            this.lblLastAutoDelete.AutoSize = true;
            this.lblLastAutoDelete.Location = new System.Drawing.Point(14, 53);
            this.lblLastAutoDelete.Name = "lblLastAutoDelete";
            this.lblLastAutoDelete.Size = new System.Drawing.Size(103, 23);
            this.lblLastAutoDelete.TabIndex = 2;
            this.lblLastAutoDelete.Text = "Last Delete :";
            // 
            // lblNextAutoBackUp
            // 
            this.lblNextAutoBackUp.AutoSize = true;
            this.lblNextAutoBackUp.Location = new System.Drawing.Point(14, 30);
            this.lblNextAutoBackUp.Name = "lblNextAutoBackUp";
            this.lblNextAutoBackUp.Size = new System.Drawing.Size(115, 23);
            this.lblNextAutoBackUp.TabIndex = 1;
            this.lblNextAutoBackUp.Text = "Next Backup :";
            // 
            // lblLastAutoBackup
            // 
            this.lblLastAutoBackup.AutoSize = true;
            this.lblLastAutoBackup.Location = new System.Drawing.Point(14, 7);
            this.lblLastAutoBackup.Name = "lblLastAutoBackup";
            this.lblLastAutoBackup.Size = new System.Drawing.Size(109, 23);
            this.lblLastAutoBackup.TabIndex = 0;
            this.lblLastAutoBackup.Text = "Last Backup :";
            // 
            // tmAutoDelete
            // 
            this.tmAutoDelete.Interval = 1000;
            this.tmAutoDelete.Tick += new System.EventHandler(this.tmAutoDelete_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Your running in background mode.";
            this.notifyIcon.BalloonTipTitle = "Database Backup Manager";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Database Manager";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 209);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1062, 473);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgList);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1054, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Database Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgLogs);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1054, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "System Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgLogs
            // 
            this.dgLogs.AllowUserToAddRows = false;
            this.dgLogs.AllowUserToDeleteRows = false;
            this.dgLogs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtlMethod,
            this.dtlDatabase,
            this.dtlOperation,
            this.dtlOperationTime,
            this.dtlIsSuccess,
            this.dtlRemarks});
            this.dgLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgLogs.Location = new System.Drawing.Point(3, 3);
            this.dgLogs.Name = "dgLogs";
            this.dgLogs.ReadOnly = true;
            this.dgLogs.RowHeadersWidth = 51;
            this.dgLogs.RowTemplate.Height = 24;
            this.dgLogs.Size = new System.Drawing.Size(1048, 431);
            this.dgLogs.TabIndex = 0;
            // 
            // dtlMethod
            // 
            this.dtlMethod.HeaderText = "Method";
            this.dtlMethod.MinimumWidth = 6;
            this.dtlMethod.Name = "dtlMethod";
            this.dtlMethod.ReadOnly = true;
            this.dtlMethod.Width = 125;
            // 
            // dtlDatabase
            // 
            this.dtlDatabase.HeaderText = "Database";
            this.dtlDatabase.MinimumWidth = 6;
            this.dtlDatabase.Name = "dtlDatabase";
            this.dtlDatabase.ReadOnly = true;
            this.dtlDatabase.Width = 125;
            // 
            // dtlOperation
            // 
            this.dtlOperation.HeaderText = "Operation";
            this.dtlOperation.MinimumWidth = 6;
            this.dtlOperation.Name = "dtlOperation";
            this.dtlOperation.ReadOnly = true;
            this.dtlOperation.Width = 125;
            // 
            // dtlOperationTime
            // 
            this.dtlOperationTime.HeaderText = "OperationTime";
            this.dtlOperationTime.MinimumWidth = 6;
            this.dtlOperationTime.Name = "dtlOperationTime";
            this.dtlOperationTime.ReadOnly = true;
            this.dtlOperationTime.Width = 125;
            // 
            // dtlIsSuccess
            // 
            this.dtlIsSuccess.HeaderText = "Completed";
            this.dtlIsSuccess.MinimumWidth = 6;
            this.dtlIsSuccess.Name = "dtlIsSuccess";
            this.dtlIsSuccess.ReadOnly = true;
            this.dtlIsSuccess.Width = 125;
            // 
            // dtlRemarks
            // 
            this.dtlRemarks.HeaderText = "Remarks";
            this.dtlRemarks.MinimumWidth = 6;
            this.dtlRemarks.Name = "dtlRemarks";
            this.dtlRemarks.ReadOnly = true;
            this.dtlRemarks.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 711);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlAuto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSettings);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 758);
            this.MinimumSize = new System.Drawing.Size(1080, 758);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Backup Manager";
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlAuto.ResumeLayout(false);
            this.pnlAuto.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnSettings;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.PictureBox btnRefresh;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.CheckBox cbBackup;
        private System.Windows.Forms.Timer tmAutoBackup;
        private System.Windows.Forms.Panel pnlAuto;
        private System.Windows.Forms.Label lblLastAutoBackup;
        private System.Windows.Forms.Label lblNextAutoDelete;
        private System.Windows.Forms.Label lblLastAutoDelete;
        private System.Windows.Forms.Label lblNextAutoBackUp;
        private System.Windows.Forms.Timer tmAutoDelete;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgLogs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlDatabase;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlOperationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlIsSuccess;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlFilename;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlCreationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlOld;
        private System.Windows.Forms.DataGridViewButtonColumn dtlDelete;
    }
}

