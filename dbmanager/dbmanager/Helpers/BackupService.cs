using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbmanager
{
    public class BackupService
    {
        public string Method { get; set; }
        public string OperationType { get; set; }
        public MainForm MainForm { get; set; }
        public async Task BackupDatabaseAsync()
        {
            var name = Properties.Settings.Default.DefaultDatabaseName + "_" + DateTime.Now.ToString("MMddyyyyhhmmsstt") + ".BAK";
            var query = String.Format("BACKUP DATABASE [{0}] TO DISK='{1}'", Properties.Settings.Default.DefaultDatabaseName, Path.Combine(Properties.Settings.Default.DefaultLocation,name));

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = Properties.Settings.Default.ConnectionString;
            SqlCommand cmd = new SqlCommand();
            try
            {
                await cn.OpenAsync();
                cmd.Connection = cn;
                cmd.CommandText = query;
                cmd.CommandTimeout = 0;
                await cmd.ExecuteNonQueryAsync();
                cmd.StatementCompleted += BackupCompleted;
                BackupCompleted(null, null);
                var item = new LoggerModel
                {
                    Database = Properties.Settings.Default.DefaultDatabaseName,
                    Method = this.Method,
                    IsSuccess = "True",
                    OperationTime = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"),
                    OperationType = this.OperationType,
                    SystemRemarks = "Process has been successfully completed."
                };
                SystemLogger.Log(item);
            }
            catch (Exception ex)
            {
                MainForm.ShowBackUpStatus(false,ex.Message);
                var item = new LoggerModel
                {
                    Database = Properties.Settings.Default.DefaultDatabaseName,
                    Method = this.Method,
                    IsSuccess = "False",
                    OperationTime = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"),
                    OperationType = "Backup",
                    SystemRemarks = ex.Message,
                };
                SystemLogger.Log(item);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
            cn.Dispose();
            cmd.Dispose();
        }

        private void BackupCompleted(object sender, StatementCompletedEventArgs e)
        {
            MainForm.ShowBackUpStatus(true);
            MainForm.RefreshBackupList();
            MainForm.LoadSystemLogs();
        }
        public bool IsDatabaseExist()
        {
            var databasename = Properties.Settings.Default.DefaultDatabaseName.ToLower();
            bool isExist = false;
            var sql = "SELECT [d].[name] FROM  [sys].[databases] [d] WHERE [d].[database_id] > 4";
            var result = DatabaseHelper.LoadDataTable(sql, Properties.Settings.Default.ConnectionString);

            foreach (DataRow dr in result.Rows)
            {
                if (dr["name"].ToString().ToLower().Equals(databasename))
                {
                    isExist = true;
                    break;
                }
            }
            return isExist;
        }
        public bool IsConnected()
        {
            bool connected = false;
            var connString = Properties.Settings.Default.ConnectionString;
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = connString;
            try
            {
                cn.Open();
                connected = true;
            }
            catch (Exception ex)
            {
                connected = false;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
            cn.Dispose();

            return connected;
        }
    }
}
