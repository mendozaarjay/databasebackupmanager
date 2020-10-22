namespace dbmanager
{
    partial class SettingsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numDaysOld = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAutoDelete = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numAutoBackup = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rbWeek = new System.Windows.Forms.RadioButton();
            this.rbDays = new System.Windows.Forms.RadioButton();
            this.rbHours = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAutobackup = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysOld)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAutoBackup)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(440, 662);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnBrowse);
            this.tabPage1.Controls.Add(this.txtLocation);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(432, 626);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Backup Manager";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(13, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(395, 48);
            this.label7.TabIndex = 8;
            this.label7.Text = "This is the default back up location. Every backup will be saved in this folder.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.numDaysOld);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbAutoDelete);
            this.groupBox2.Location = new System.Drawing.Point(12, 416);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 195);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Automatic Delete";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(11, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(395, 48);
            this.label6.TabIndex = 8;
            this.label6.Text = "Remove/delete backup database depending on the set up age(days) to avoid large di" +
    "sk consumption.";
            // 
            // numDaysOld
            // 
            this.numDaysOld.DecimalPlaces = 2;
            this.numDaysOld.Location = new System.Drawing.Point(11, 94);
            this.numDaysOld.Name = "numDaysOld";
            this.numDaysOld.Size = new System.Drawing.Size(395, 30);
            this.numDaysOld.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Age(Days)";
            // 
            // cbAutoDelete
            // 
            this.cbAutoDelete.AutoSize = true;
            this.cbAutoDelete.Location = new System.Drawing.Point(7, 30);
            this.cbAutoDelete.Name = "cbAutoDelete";
            this.cbAutoDelete.Size = new System.Drawing.Size(158, 27);
            this.cbAutoDelete.TabIndex = 0;
            this.cbAutoDelete.Text = "Run Auto Delete";
            this.cbAutoDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numAutoBackup);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbWeek);
            this.groupBox1.Controls.Add(this.rbDays);
            this.groupBox1.Controls.Add(this.rbHours);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbAutobackup);
            this.groupBox1.Location = new System.Drawing.Point(12, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 259);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Automatic Backup";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(11, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(395, 48);
            this.label5.TabIndex = 7;
            this.label5.Text = "Backup database every hours, days or week to  automatically depending on the set " +
    "up value.";
            // 
            // numAutoBackup
            // 
            this.numAutoBackup.DecimalPlaces = 2;
            this.numAutoBackup.Location = new System.Drawing.Point(11, 161);
            this.numAutoBackup.Name = "numAutoBackup";
            this.numAutoBackup.Size = new System.Drawing.Size(395, 30);
            this.numAutoBackup.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Value";
            // 
            // rbWeek
            // 
            this.rbWeek.AutoSize = true;
            this.rbWeek.Location = new System.Drawing.Point(241, 95);
            this.rbWeek.Name = "rbWeek";
            this.rbWeek.Size = new System.Drawing.Size(72, 27);
            this.rbWeek.TabIndex = 4;
            this.rbWeek.TabStop = true;
            this.rbWeek.Text = "Week";
            this.rbWeek.UseVisualStyleBackColor = true;
            // 
            // rbDays
            // 
            this.rbDays.AutoSize = true;
            this.rbDays.Location = new System.Drawing.Point(129, 95);
            this.rbDays.Name = "rbDays";
            this.rbDays.Size = new System.Drawing.Size(67, 27);
            this.rbDays.TabIndex = 3;
            this.rbDays.TabStop = true;
            this.rbDays.Text = "Days";
            this.rbDays.UseVisualStyleBackColor = true;
            // 
            // rbHours
            // 
            this.rbHours.AutoSize = true;
            this.rbHours.Location = new System.Drawing.Point(11, 95);
            this.rbHours.Name = "rbHours";
            this.rbHours.Size = new System.Drawing.Size(76, 27);
            this.rbHours.TabIndex = 2;
            this.rbHours.TabStop = true;
            this.rbHours.Text = "Hours";
            this.rbHours.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Schedule";
            // 
            // cbAutobackup
            // 
            this.cbAutobackup.AutoSize = true;
            this.cbAutobackup.Location = new System.Drawing.Point(7, 30);
            this.cbAutobackup.Name = "cbAutobackup";
            this.cbAutobackup.Size = new System.Drawing.Size(206, 27);
            this.cbAutobackup.TabIndex = 0;
            this.cbAutobackup.Text = "Run Automatic Backup";
            this.cbAutobackup.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(389, 42);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(38, 30);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(12, 42);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(369, 30);
            this.txtLocation.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Default Location";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtDatabaseName);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.btnTestConnection);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtConnectionString);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(432, 626);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Connection Manager";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(11, 393);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(415, 31);
            this.label11.TabIndex = 13;
            this.label11.Text = "This is the default database name that will be backed up.";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(13, 354);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(411, 30);
            this.txtDatabaseName.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 23);
            this.label10.TabIndex = 11;
            this.label10.Text = "Database Name";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(13, 255);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(411, 44);
            this.btnTestConnection.TabIndex = 10;
            this.btnTestConnection.Text = "Test Database Connection";
            this.btnTestConnection.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(9, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(415, 79);
            this.label9.TabIndex = 9;
            this.label9.Text = "This is the default sql connection string. This will be use to connect to the ser" +
    "ver where the database that will be backed up is located.";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(13, 55);
            this.txtConnectionString.Multiline = true;
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConnectionString.Size = new System.Drawing.Size(411, 119);
            this.txtConnectionString.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Connection String";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(285, 664);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(151, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(4, 664);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(151, 38);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear Settings";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 711);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysOld)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAutoBackup)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbAutobackup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbHours;
        private System.Windows.Forms.RadioButton rbWeek;
        private System.Windows.Forms.RadioButton rbDays;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numAutoBackup;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numDaysOld;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbAutoDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label label10;
    }
}