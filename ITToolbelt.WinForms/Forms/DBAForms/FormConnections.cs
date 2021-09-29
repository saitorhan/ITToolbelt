using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ITToolbelt.Bll.Managers;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.Enum;
using ITToolbelt.Shared;
using ITToolbelt.WinForms.ExtensionMethods;
using ITToolbelt.WinForms.Forms.ControlSpesifications;

namespace ITToolbelt.WinForms.Forms.DBAForms
{
    public partial class FormConnections : Form
    {
        private bool getFromServer;
        private BackgroundWorker backgroundWorker;
        public FormConnections()
        {
            InitializeComponent();
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBarConnections.StartStopMarque();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            RefreshData();
        }

        private void FormConnections_Load(object sender, EventArgs e)
        {
            dataGridViewConnections.LoadGridColumnStatus();
            getFromServer = false;
            toolStripProgressBarConnections.StartStopMarque();
            backgroundWorker.RunWorkerAsync();
        }

        private void RefreshData()
        {
            ConnectionManager connectionManager = new ConnectionManager(GlobalVariables.ConnectInfo);
            List<Connection> connections = connectionManager.GetConnections(getFromServer);
            connectionBindingSource.DataSource = connections;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormMsSqlLogin msSqlLogin = new FormMsSqlLogin();
            msSqlLogin.ShowDialog();

            if (msSqlLogin.SuccessFlag)
            {
                getFromServer = true;
                toolStripProgressBarConnections.StartStopMarque();
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            getFromServer = true;
            toolStripProgressBarConnections.StartStopMarque();
            backgroundWorker.RunWorkerAsync();
        }

        private void dataGridViewConnections_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            DataGridViewRow row = dataGridViewConnections.Rows[e.RowIndex];
            DataGridViewCell cell = row.Cells[17];
            if (cell.Value != null && cell.Value.ToString() == Resource._017)
            {
                row.DefaultCellStyle.BackColor = Color.Red;
                row.DefaultCellStyle.ForeColor = Color.White;
            }
        }

        private void buttonColumnSelection_Click(object sender, EventArgs e)
        {
            DataGridViewColumnCollection dataGridViewColumnCollection = dataGridViewConnections.Columns;
            FormGridColumnSelection formGridColumnSelection = new FormGridColumnSelection(dataGridViewColumnCollection);
            formGridColumnSelection.ShowDialog();
        }

        private void FormConnections_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataGridViewConnections.SaveGridColumnStatus();
        }

        private void buttonAddMySql_Click(object sender, EventArgs e)
        {
            FormMySqlLogin msSqlLogin = new FormMySqlLogin();
            msSqlLogin.ShowDialog();

            if (msSqlLogin.SuccessFlag)
            {
                getFromServer = true;
                toolStripProgressBarConnections.StartStopMarque();
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewConnections.SelectedRows.Count == 0 || !(dataGridViewConnections.SelectedRows[0].DataBoundItem is Connection))
            {
                return;
            }

            Connection connection = dataGridViewConnections.SelectedRows[0].DataBoundItem as Connection;
            if (connection == null)
            {
                return;
            }

            bool result = false;
            Form form = connection.DbServerTypeCode == DbServerType.MsSql ? new FormMsSqlLogin(connection) : (Form)new FormMySqlLogin(connection);
            form.ShowDialog();

            switch (form)
            {
                case FormMsSqlLogin login:
                    result = login.SuccessFlag;
                    break;
                case FormMySqlLogin sqlLogin:
                    result = sqlLogin.SuccessFlag;
                    break;
            }

            if (result)
            {
                RefreshData();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewConnections.SelectedRows.Count == 0 || !(dataGridViewConnections.SelectedRows[0].DataBoundItem is Connection))
            {
                return;
            }

            Connection connection = dataGridViewConnections.SelectedRows[0].DataBoundItem as Connection;
            if (connection == null)
            {
                return;
            }
            if (GlobalMethods.DeleteConfirm(connection.Name) != DialogResult.Yes)
            {
                return;
            }
            ConnectionManager connectionManager = new ConnectionManager(GlobalVariables.ConnectInfo);
            bool delete = connectionManager.Delete(connection.Id);
            if (delete)
            {
                RefreshData();
            }
        }
    }
}
