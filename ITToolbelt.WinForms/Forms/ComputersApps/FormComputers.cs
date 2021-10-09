using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ITToolbelt.Bll.Managers;
using ITToolbelt.Entity.Db;
using ITToolbelt.Shared;
using ITToolbelt.WinForms.ExtensionMethods;
using ITToolbelt.WinForms.Forms.ControlSpesifications;

namespace ITToolbelt.WinForms.Forms.ComputersApps
{
    public partial class FormComputers : Form
    {
        private WorkerStatus wStatus;
        public FormComputers()
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
                    SyncComputersWithAd();
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
            ComputerManager computerManager = new ComputerManager(GlobalVariables.ConnectInfo);
            List<Computer> groups = computerManager.GetAll();

            if (dataGridViewComputers.InvokeRequired)
            {
                dataGridViewComputers.Invoke(new Action(delegate
                {
                    computerBindingSource.DataSource = groups;
                }));
            }
            else
            {
                computerBindingSource.DataSource = groups;
            }
        }

        enum WorkerStatus
        {
            RefreshData,
            GetFromDc
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            dataGridViewComputers.LoadGridColumnStatus();

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
            dataGridViewComputers.SaveGridColumnStatus();
        }

        private void buttonColumnSelection_Click(object sender, EventArgs e)
        {
            FormGridColumnSelection formGridColumn = new FormGridColumnSelection(dataGridViewComputers.Columns);
            formGridColumn.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormComputer formUser = new FormComputer();
            formUser.ShowDialog();

            wStatus = WorkerStatus.RefreshData;
            toolStripProgressBarStatus.StartStopMarque();
            backgroundWorkerWorker.RunWorkerAsync();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewComputers.SelectedRows.Count == 0 || !(dataGridViewComputers.SelectedRows[0].DataBoundItem is Computer))
            {
                return;
            }

            Computer computer = dataGridViewComputers.SelectedRows[0].DataBoundItem as Computer;
            if (computer == null)
            {
                return;
            }

            FormComputer formComputer = new FormComputer(computer);
            formComputer.ShowDialog();

            wStatus = WorkerStatus.RefreshData;
            toolStripProgressBarStatus.StartStopMarque();
            backgroundWorkerWorker.RunWorkerAsync();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewComputers.SelectedRows.Count == 0 || !(dataGridViewComputers.SelectedRows[0].DataBoundItem is Computer))
            {
                return;
            }

            Computer computer = dataGridViewComputers.SelectedRows[0].DataBoundItem as Computer;
            if (computer == null)
            {
                return;
            }
            if (GlobalMethods.DeleteConfirm(computer.Name) != DialogResult.Yes)
            {
                return;
            }

            ComputerManager computerManager = new ComputerManager(GlobalVariables.ConnectInfo);
            Tuple<bool, List<string>> delete = computerManager.Delete(computer.Id);
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

        void SyncComputersWithAd()
        {
            ComputerManager computerManager = new ComputerManager(GlobalVariables.ConnectInfo);
            Tuple<bool, List<string>> syncUsersWithAd = computerManager.SyncComputersWithAd();
            syncUsersWithAd.ShowDialog();

            if (syncUsersWithAd.Item1)
            {
                RefreshData();
            }
        }

        private void buttonFreeComputer_Click(object sender, EventArgs e)
        {
            if (dataGridViewComputers.SelectedRows.Count == 0 || !(dataGridViewComputers.SelectedRows[0].DataBoundItem is Computer))
            {
                return;
            }

            Computer computer = dataGridViewComputers.SelectedRows[0].DataBoundItem as Computer;
            if (computer == null)
            {
                return;
            }
            if (MessageBox.Show(String.Format(Resource._033, computer.Name, computer.User?.Fullname), Resource._009, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            ComputerManager computerManager = new ComputerManager(GlobalVariables.ConnectInfo);
            Tuple<bool, List<string>> delete = computerManager.RemoveUserFromComputer(computer.Id);
            delete.ShowDialog();
            if (delete.Item1)
            {
                wStatus = WorkerStatus.RefreshData;
                toolStripProgressBarStatus.StartStopMarque();
                backgroundWorkerWorker.RunWorkerAsync();
            }
        }

        private void dataGridViewGroups_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewComputers.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow selectedRow in dataGridViewComputers.SelectedRows)
            {
                Computer index = selectedRow.DataBoundItem as Computer;
                if (index.UserId != null)
                {
                    buttonFreeComputer.Enabled = true;
                    return;
                }
            }

            buttonFreeComputer.Enabled = false;
        }
    }
}
