using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ITToolbelt.Bll.Managers;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.Enum;
using ITToolbelt.WinForms.ExtensionMethods;
using ITToolbelt.WinForms.Forms.ControlSpesifications;

namespace ITToolbelt.WinForms.Forms.MainAppForms
{
    public partial class FormMetadatas : Form
    {
        private WorkerStatus wStatus;
        public FormMetadatas()
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
            MetadataManager metadataManager = new MetadataManager(GlobalVariables.ConnectInfo);
            List<Metadata> metadatas = metadataManager.GetAll();

            if (dataGridViewMetadatas.InvokeRequired)
            {
                dataGridViewMetadatas.Invoke(new Action(delegate
                {
                    metadataBindingSource.DataSource = metadatas;
                }));
            }
            else
            {
                metadataBindingSource.DataSource = metadatas;
            }
        }

        enum WorkerStatus
        {
            RefreshData
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            dataGridViewMetadatas.LoadGridColumnStatus();

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
            dataGridViewMetadatas.SaveGridColumnStatus();
        }

        private void buttonColumnSelection_Click(object sender, EventArgs e)
        {
            FormGridColumnSelection formGridColumn = new FormGridColumnSelection(dataGridViewMetadatas.Columns);
            formGridColumn.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormMetadata formUser = new FormMetadata();
            formUser.ShowDialog();

            wStatus = WorkerStatus.RefreshData;
            toolStripProgressBarStatus.StartStopMarque();
            backgroundWorkerWorker.RunWorkerAsync();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewMetadatas.SelectedRows.Count == 0 || !(dataGridViewMetadatas.SelectedRows[0].DataBoundItem is Metadata))
            {
                return;
            }

            Metadata computer = dataGridViewMetadatas.SelectedRows[0].DataBoundItem as Metadata;
            if (computer == null)
            {
                return;
            }

            FormMetadata formMetadata = new FormMetadata(computer);
            formMetadata.ShowDialog();

            wStatus = WorkerStatus.RefreshData;
            toolStripProgressBarStatus.StartStopMarque();
            backgroundWorkerWorker.RunWorkerAsync();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewMetadatas.SelectedRows.Count == 0 || !(dataGridViewMetadatas.SelectedRows[0].DataBoundItem is Metadata))
            {
                return;
            }

            Metadata computer = dataGridViewMetadatas.SelectedRows[0].DataBoundItem as Metadata;
            if (computer == null)
            {
                return;
            }
            if (GlobalMethods.DeleteConfirm($"{computer.MetadataType.ToString()} - {computer.Value} ") != DialogResult.Yes)
            {
                return;
            }

            MetadataManager computerManager = new MetadataManager(GlobalVariables.ConnectInfo);
            Tuple<bool, List<string>> delete = computerManager.Delete(computer.Id);
            delete.ShowDialog();
            if (delete.Item1)
            {
                wStatus = WorkerStatus.RefreshData;
                toolStripProgressBarStatus.StartStopMarque();
                backgroundWorkerWorker.RunWorkerAsync();
            }
        }
    }
}
