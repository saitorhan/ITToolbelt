
namespace ITToolbelt.WinForms.Forms.ComputersApps
{
    partial class FormComputers
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComputers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonfromAd = new System.Windows.Forms.Button();
            this.buttonResfresh = new System.Windows.Forms.Button();
            this.buttonColumnSelection = new System.Windows.Forms.Button();
            this.buttonFreeComputer = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewComputers = new System.Windows.Forms.DataGridView();
            this.computerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBarStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.backgroundWorkerWorker = new System.ComponentModel.BackgroundWorker();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComputers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.buttonfromAd);
            this.panel1.Controls.Add(this.buttonResfresh);
            this.panel1.Controls.Add(this.buttonColumnSelection);
            this.panel1.Controls.Add(this.buttonFreeComputer);
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Name = "panel1";
            // 
            // buttonfromAd
            // 
            resources.ApplyResources(this.buttonfromAd, "buttonfromAd");
            this.buttonfromAd.Image = global::ITToolbelt.WinForms.Properties.Resources.download_to_computer;
            this.buttonfromAd.Name = "buttonfromAd";
            this.buttonfromAd.UseVisualStyleBackColor = true;
            this.buttonfromAd.Click += new System.EventHandler(this.buttonfromAd_Click);
            // 
            // buttonResfresh
            // 
            resources.ApplyResources(this.buttonResfresh, "buttonResfresh");
            this.buttonResfresh.Image = global::ITToolbelt.WinForms.Properties.Resources.refresh;
            this.buttonResfresh.Name = "buttonResfresh";
            this.buttonResfresh.UseVisualStyleBackColor = true;
            this.buttonResfresh.Click += new System.EventHandler(this.buttonResfresh_Click);
            // 
            // buttonColumnSelection
            // 
            resources.ApplyResources(this.buttonColumnSelection, "buttonColumnSelection");
            this.buttonColumnSelection.Image = global::ITToolbelt.WinForms.Properties.Resources.edit_page;
            this.buttonColumnSelection.Name = "buttonColumnSelection";
            this.buttonColumnSelection.UseVisualStyleBackColor = true;
            this.buttonColumnSelection.Click += new System.EventHandler(this.buttonColumnSelection_Click);
            // 
            // buttonFreeComputer
            // 
            resources.ApplyResources(this.buttonFreeComputer, "buttonFreeComputer");
            this.buttonFreeComputer.Image = global::ITToolbelt.WinForms.Properties.Resources.delete_user;
            this.buttonFreeComputer.Name = "buttonFreeComputer";
            this.buttonFreeComputer.UseVisualStyleBackColor = true;
            this.buttonFreeComputer.Click += new System.EventHandler(this.buttonFreeComputer_Click);
            // 
            // buttonRemove
            // 
            resources.ApplyResources(this.buttonRemove, "buttonRemove");
            this.buttonRemove.Image = global::ITToolbelt.WinForms.Properties.Resources.delete;
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonUpdate
            // 
            resources.ApplyResources(this.buttonUpdate, "buttonUpdate");
            this.buttonUpdate.Image = global::ITToolbelt.WinForms.Properties.Resources.edit_page;
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            resources.ApplyResources(this.buttonAdd, "buttonAdd");
            this.buttonAdd.Image = global::ITToolbelt.WinForms.Properties.Resources.add;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.dataGridViewComputers);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // dataGridViewComputers
            // 
            resources.ApplyResources(this.dataGridViewComputers, "dataGridViewComputers");
            this.dataGridViewComputers.AllowUserToAddRows = false;
            this.dataGridViewComputers.AllowUserToDeleteRows = false;
            this.dataGridViewComputers.AllowUserToOrderColumns = true;
            this.dataGridViewComputers.AutoGenerateColumns = false;
            this.dataGridViewComputers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComputers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.SerialNumber,
            this.UserMail,
            this.descDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn});
            this.dataGridViewComputers.DataSource = this.computerBindingSource;
            this.dataGridViewComputers.Name = "dataGridViewComputers";
            this.dataGridViewComputers.ReadOnly = true;
            this.dataGridViewComputers.Tag = "D18BB5E5FA3A4D078F812F673C017920";
            this.dataGridViewComputers.SelectionChanged += new System.EventHandler(this.dataGridViewGroups_SelectionChanged);
            // 
            // computerBindingSource
            // 
            this.computerBindingSource.DataSource = typeof(ITToolbelt.Entity.Db.Computer);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBarStatus});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripProgressBarStatus
            // 
            resources.ApplyResources(this.toolStripProgressBarStatus, "toolStripProgressBarStatus");
            this.toolStripProgressBarStatus.Name = "toolStripProgressBarStatus";
            // 
            // backgroundWorkerWorker
            // 
            this.backgroundWorkerWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerWorker_DoWork);
            this.backgroundWorkerWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerWorker_RunWorkerCompleted);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SerialNumber
            // 
            this.SerialNumber.DataPropertyName = "SerialNumber";
            resources.ApplyResources(this.SerialNumber, "SerialNumber");
            this.SerialNumber.Name = "SerialNumber";
            this.SerialNumber.ReadOnly = true;
            // 
            // UserMail
            // 
            this.UserMail.DataPropertyName = "UserMail";
            resources.ApplyResources(this.UserMail, "UserMail");
            this.UserMail.Name = "UserMail";
            this.UserMail.ReadOnly = true;
            // 
            // descDataGridViewTextBoxColumn
            // 
            this.descDataGridViewTextBoxColumn.DataPropertyName = "Desc";
            resources.ApplyResources(this.descDataGridViewTextBoxColumn, "descDataGridViewTextBoxColumn");
            this.descDataGridViewTextBoxColumn.Name = "descDataGridViewTextBoxColumn";
            this.descDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            resources.ApplyResources(this.userDataGridViewTextBoxColumn, "userDataGridViewTextBoxColumn");
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormComputers
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FormComputers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUsers_FormClosing);
            this.Load += new System.EventHandler(this.FormUsers_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComputers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewComputers;
        private System.Windows.Forms.BindingSource computerBindingSource;
        private System.Windows.Forms.Button buttonResfresh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorkerWorker;
        private System.Windows.Forms.Button buttonColumnSelection;
        private System.Windows.Forms.Button buttonfromAd;
        private System.Windows.Forms.Button buttonFreeComputer;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn descDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
    }
}