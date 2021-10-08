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

namespace ITToolbelt.WinForms.Forms.Computers
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

            if (dataGridViewGroups.InvokeRequired)
            {
                dataGridViewGroups.Invoke(new Action(delegate
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
            FormComputer formUser = new FormComputer();
            formUser.ShowDialog();

            wStatus = WorkerStatus.RefreshData;
            toolStripProgressBarStatus.StartStopMarque();
            backgroundWorkerWorker.RunWorkerAsync();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewGroups.SelectedRows.Count == 0 || !(dataGridViewGroups.SelectedRows[0].DataBoundItem is Computer))
            {
                return;
            }

            Computer computer = dataGridViewGroups.SelectedRows[0].DataBoundItem as Computer;
            if (computer == null)
            {
                return;
            }

            FormComputer formUser = new FormComputer(computer);
            formUser.ShowDialog();

            wStatus = WorkerStatus.RefreshData;
            toolStripProgressBarStatus.StartStopMarque();
            backgroundWorkerWorker.RunWorkerAsync();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewGroups.SelectedRows.Count == 0 || !(dataGridViewGroups.SelectedRows[0].DataBoundItem is Computer))
            {
                return;
            }

            Computer computer = dataGridViewGroups.SelectedRows[0].DataBoundItem as Computer;
            if (computer == null)
            {
                return;
            }
            if (GlobalMethods.DeleteConfirm(computer.Name) != DialogResult.Yes)
            {
                return;
            }
            ComputerManager groupManager = new ComputerManager(GlobalVariables.ConnectInfo);
            Tuple<bool, List<string>> delete = groupManager.Delete(computer.Id);
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
            ComputerManager groupManager = new ComputerManager(GlobalVariables.ConnectInfo);
            Tuple<bool, List<string>> syncUsersWithAd = groupManager.SyncComputersWithAd();
            syncUsersWithAd.ShowDialog();

            if (syncUsersWithAd.Item1)
            {
                RefreshData();
            }
        }
    }
}
