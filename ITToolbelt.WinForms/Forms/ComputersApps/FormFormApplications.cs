using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ITToolbelt.Bll.Managers;
using ITToolbelt.Entity.Db;
using ITToolbelt.WinForms.ExtensionMethods;
using ITToolbelt.WinForms.Forms.ControlSpesifications;

namespace ITToolbelt.WinForms.Forms.ComputersApps
{
    public partial class FormApplications : Form
    {
        private WorkerStatus wStatus;
        public FormApplications()
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
                case WorkerStatus.GetFromDc:
                    SyncUsersWithAd();
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
            GroupManager groupManager = new GroupManager(GlobalVariables.ConnectInfo);
            List<Group> groups = groupManager.GetAll();

            if (dataGridViewGroups.InvokeRequired)
            {
                dataGridViewGroups.Invoke(new Action(delegate
                {
                    applicationBindingSource.DataSource = groups;
                }));
            }
            else
            {
                applicationBindingSource.DataSource = groups;
            }
        }

        enum WorkerStatus
        {
            RefreshData,
            GetFromDc
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            dataGridViewGroups.LoadGridColumnStatus();

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
            dataGridViewGroups.SaveGridColumnStatus();
        }

        private void buttonColumnSelection_Click(object sender, EventArgs e)
        {
            FormGridColumnSelection formGridColumn = new FormGridColumnSelection(dataGridViewGroups.Columns);
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
            if (dataGridViewGroups.SelectedRows.Count == 0 || !(dataGridViewGroups.SelectedRows[0].DataBoundItem is Group))
            {
                return;
            }

            Group group = dataGridViewGroups.SelectedRows[0].DataBoundItem as Group;
            if (group == null)
            {
                return;
            }

            FormGroup formUser = new FormGroup(group);
            formUser.ShowDialog();

            wStatus = WorkerStatus.RefreshData;
            toolStripProgressBarStatus.StartStopMarque();
            backgroundWorkerWorker.RunWorkerAsync();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewGroups.SelectedRows.Count == 0 || !(dataGridViewGroups.SelectedRows[0].DataBoundItem is Group))
            {
                return;
            }

            Group group = dataGridViewGroups.SelectedRows[0].DataBoundItem as Group;
            if (group == null)
            {
                return;
            }
            if (GlobalMethods.DeleteConfirm(group.Name) != DialogResult.Yes)
            {
                return;
            }
            GroupManager groupManager = new GroupManager(GlobalVariables.ConnectInfo);
            Tuple<bool, List<string>> delete = groupManager.Delete(group.Id);
            delete.ShowDialog();
            if (delete.Item1)
            {
                wStatus = WorkerStatus.RefreshData;
                toolStripProgressBarStatus.StartStopMarque();
                backgroundWorkerWorker.RunWorkerAsync();
            }
        }

        private void buttonfromAd_Click(object sender, EventArgs e)
        {
            wStatus = WorkerStatus.GetFromDc;
            toolStripProgressBarStatus.StartStopMarque();
            backgroundWorkerWorker.RunWorkerAsync();
        }

        void SyncUsersWithAd()
        {
            GroupManager groupManager = new GroupManager(GlobalVariables.ConnectInfo);
            Tuple<bool, List<string>> syncUsersWithAd = groupManager.SyncUsersWithAd();
            syncUsersWithAd.ShowDialog();

            if (syncUsersWithAd.Item1)
            {
                RefreshData();
            }
        }
    }
}
