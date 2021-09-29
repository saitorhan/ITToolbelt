using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITToolbelt.Bll.Managers;
using ITToolbelt.Entity.Db;
using ITToolbelt.WinForms.ExtensionMethods;
using ITToolbelt.WinForms.Forms.ControlSpesifications;

namespace ITToolbelt.WinForms.Forms.UserAndGroups
{
    public partial class FormUsers : Form
    {
        private WorkerStatus wStatus;
        public FormUsers()
        {
            InitializeComponent();
        }

        private void backgroundWorkerWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (wStatus)
            {
                case WorkerStatus.RefreshData:
                    RefreshData();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void backgroundWorkerWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripProgressBarStatus.StartStopMarque();
        }

        public void RefreshData()
        {
            UserManager userManager = new UserManager(GlobalVariables.ConnectInfo);
            List<User> users = userManager.GetAll();

            userBindingSource.DataSource = users;
        }

        enum WorkerStatus
        {
            RefreshData
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            dataGridViewUsers.LoadGridColumnStatus();

            wStatus = WorkerStatus.RefreshData;
            toolStripProgressBarStatus.StartStopMarque();
            backgroundWorkerWorker.RunWorkerAsync();
        }

        private void buttonResfresh_Click(object sender, EventArgs e)
        {
            wStatus = WorkerStatus.RefreshData;
            toolStripProgressBarStatus.StartStopMarque();
            backgroundWorkerWorker.RunWorkerAsync();
        }

        private void FormUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataGridViewUsers.SaveGridColumnStatus();
        }

        private void buttonColumnSelection_Click(object sender, EventArgs e)
        {
            FormGridColumnSelection formGridColumn = new FormGridColumnSelection(dataGridViewUsers.Columns);
            formGridColumn.ShowDialog();
        }
    }
}
