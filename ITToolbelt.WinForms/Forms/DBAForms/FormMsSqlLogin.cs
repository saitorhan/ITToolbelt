using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using ITToolbelt.Bll.Managers;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.Enum;
using ITToolbelt.Shared;
using ITToolbelt.WinForms.ExtensionMethods;

namespace ITToolbelt.WinForms.Forms.DBAForms
{
    public partial class FormMsSqlLogin : Form
    {
        public bool SuccessFlag { get; set; }
        public string ConnectionString => sqlConnectionString.ConnectionString;
        public Connection Connection { get; set; }

        private readonly SqlConnectionStringBuilder sqlConnectionString;
        private readonly BackgroundWorker backgroundWorker;
        private AutoResetEvent autoResetEvent = new AutoResetEvent(false);
        public FormMsSqlLogin()
        {
            InitializeComponent();
            sqlConnectionString = new SqlConnectionStringBuilder();
            comboBoxAuthType.SelectedIndex = 0;

            Connection = new Connection { DbServerTypeCode = DbServerType.MsSql };

            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBarConnection.StartStopMarque();
        }

        public FormMsSqlLogin(Connection connection)
        {
            InitializeComponent();
            Connection = connection;

            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;

            sqlConnectionString = new SqlConnectionStringBuilder(connection.ConnectionString);

            textBoxConName.Text = connection.Name;
            textBoxServerName.Text = sqlConnectionString.DataSource;
            comboBoxAuthType.SelectedIndex = Convert.ToInt32(!sqlConnectionString.IntegratedSecurity);
            if (!sqlConnectionString.IntegratedSecurity)
            {
                textBoxUserName.Text = sqlConnectionString.UserID;
                textBoxPassword.Text = sqlConnectionString.Password;
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            sqlConnectionString.DataSource = textBoxServerName.Text;
            sqlConnectionString.IntegratedSecurity = comboBoxAuthType.SelectedIndex == 0;
            if (!sqlConnectionString.IntegratedSecurity)
            {
                sqlConnectionString.UserID = textBoxUserName.Text;
                sqlConnectionString.Password = textBoxPassword.Text;
            }

            SqlConnection sqlConnection = new SqlConnection(sqlConnectionString.ConnectionString);
            try
            {
                sqlConnection.Open();
                sqlConnection.Close();
                SuccessFlag = true;

                Connection.Name = textBoxConName.Text;
                Connection.ConnectionString = sqlConnectionString.ConnectionString;
                ConnectionManager connectionManager = new ConnectionManager(GlobalVariables.ConnectInfo);
                SuccessFlag = Connection.Id > 0 ? connectionManager.Update(Connection) : connectionManager.Add(Connection);
                
            }
            catch (Exception exception)
            {
                SuccessFlag = false;
            }
            finally
            {
                if (sqlConnection.State != ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }

            MessageBox.Show($"{Resource._015} {(SuccessFlag ? Resource._016 : Resource._017)}", SuccessFlag ? Resource._012 : Resource._005, MessageBoxButtons.OK, SuccessFlag ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            if (SuccessFlag)
            {
                Close();
            }
        }

        private void buttonHelp_Click(object sender, System.EventArgs e)
        {
            Process.Start("https://docs.microsoft.com/en-us/sql/ssms/f1-help/connect-to-server-database-engine");
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            SuccessFlag = false;
            Close();
        }

        private void buttonConnect_Click(object sender, System.EventArgs e)
        {
            progressBarConnection.StartStopMarque();
            backgroundWorker.RunWorkerAsync();
        }

        private void comboBoxAuthType_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            textBoxUserName.Enabled =
                textBoxPassword.Enabled = comboBoxAuthType.SelectedIndex > 0;
        }
    }
}
