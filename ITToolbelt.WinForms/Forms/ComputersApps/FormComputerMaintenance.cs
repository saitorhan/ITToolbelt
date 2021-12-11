using ITToolbelt.WinForms.ExtensionMethods;
using ITToolbelt.WinForms.Forms.ControlSpesifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = ITToolbelt.Entity.Db.Application;

namespace ITToolbelt.WinForms.Forms.ComputersApps
{
    public partial class FormComputerMaintenance : Form
    {
        private WorkerStatus wStatus;
        public FormComputerMaintenance()
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

        private void RefreshData()
        {
            //ApplicationManeger applicationManeger = new ApplicationManeger(GlobalVariables.ConnectInfo);
            //List<Application> applications = applicationManeger.GetAll();

            //if (dataGridViewApplications.InvokeRequired)
            //{
            //    dataGridViewApplications.Invoke(new Action(delegate
            //    {
            //        applicationBindingSource.DataSource = applications;
            //    }));
            //}
            //else
            //{
            //    applicationBindingSource.DataSource = applications;
            //}
        }

        enum WorkerStatus
        {
            RefreshData
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            dataGridViewApplications.LoadGridColumnStatus();

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
            dataGridViewApplications.SaveGridColumnStatus();
        }

        private void buttonColumnSelection_Click(object sender, EventArgs e)
        {
            FormGridColumnSelection formGridColumn = new FormGridColumnSelection(dataGridViewApplications.Columns);
            formGridColumn.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormApplication formUser = new FormApplication();
            formUser.ShowDialog();

            wStatus = WorkerStatus.RefreshData;
            toolStripProgressBarStatus.StartStopMarque();
            backgroundWorkerWorker.RunWorkerAsync();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewApplications.SelectedRows.Count == 0 || !(dataGridViewApplications.SelectedRows[0].DataBoundItem is Application))
            {
                return;
            }

            Application application = dataGridViewApplications.SelectedRows[0].DataBoundItem as Application;
            if (application == null)
            {
                return;
            }

            //FormApplication formUser = new FormApplication(application);
            //formUser.ShowDialog();

            //wStatus = WorkerStatus.RefreshData;
            //toolStripProgressBarStatus.StartStopMarque();
            //backgroundWorkerWorker.RunWorkerAsync();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewApplications.SelectedRows.Count == 0 || !(dataGridViewApplications.SelectedRows[0].DataBoundItem is Application))
            {
                return;
            }

            Application application = dataGridViewApplications.SelectedRows[0].DataBoundItem as Application;
            if (application == null)
            {
                return;
            }
            if (GlobalMethods.DeleteConfirm(application.Name) != DialogResult.Yes)
            {
                return;
            }
            //ApplicationManeger applicationManeger = new ApplicationManeger(GlobalVariables.ConnectInfo);
            //Tuple<bool, List<string>> delete = applicationManeger.Delete(application.Id);
            //delete.ShowDialog();
            //if (delete.Item1)
            //{
            //    wStatus = WorkerStatus.RefreshData;
            //    toolStripProgressBarStatus.StartStopMarque();
            //    backgroundWorkerWorker.RunWorkerAsync();
            //}
        }
    }
}
