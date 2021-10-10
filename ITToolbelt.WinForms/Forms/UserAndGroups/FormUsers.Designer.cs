
namespace ITToolbelt.WinForms.Forms.UserAndGroups
{
    partial class FormUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsers));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonfromAd = new System.Windows.Forms.Button();
            this.buttonResfresh = new System.Windows.Forms.Button();
            this.buttonColumnSelection = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBarStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.backgroundWorkerWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonfromAd);
            this.panel1.Controls.Add(this.buttonResfresh);
            this.panel1.Controls.Add(this.buttonColumnSelection);
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonAdd);
            resources.ApplyResources(this.panel1, "panel1");
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
            // buttonRemove
            // 
            this.buttonRemove.Image = global::ITToolbelt.WinForms.Properties.Resources.delete;
            resources.ApplyResources(this.buttonRemove, "buttonRemove");
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Image = global::ITToolbelt.WinForms.Properties.Resources.edit_page;
            resources.ApplyResources(this.buttonUpdate, "buttonUpdate");
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Image = global::ITToolbelt.WinForms.Properties.Resources.add;
            resources.ApplyResources(this.buttonAdd, "buttonAdd");
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewUsers);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToOrderColumns = true;
            this.dataGridViewUsers.AutoGenerateColumns = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Username,
            this.firstnameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.fullnameDataGridViewTextBoxColumn});
            this.dataGridViewUsers.DataSource = this.userBindingSource;
            resources.ApplyResources(this.dataGridViewUsers, "dataGridViewUsers");
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.Tag = "9CE9BAEE938448EB828E1058C30EB6AF";
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            resources.ApplyResources(this.Username, "Username");
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname";
            resources.ApplyResources(this.firstnameDataGridViewTextBoxColumn, "firstnameDataGridViewTextBoxColumn");
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            resources.ApplyResources(this.surnameDataGridViewTextBoxColumn, "surnameDataGridViewTextBoxColumn");
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            resources.ApplyResources(this.mailDataGridViewTextBoxColumn, "mailDataGridViewTextBoxColumn");
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            resources.ApplyResources(this.fullnameDataGridViewTextBoxColumn, "fullnameDataGridViewTextBoxColumn");
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ITToolbelt.Entity.Db.User);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBarStatus});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripProgressBarStatus
            // 
            this.toolStripProgressBarStatus.Name = "toolStripProgressBarStatus";
            resources.ApplyResources(this.toolStripProgressBarStatus, "toolStripProgressBarStatus");
            // 
            // backgroundWorkerWorker
            // 
            this.backgroundWorkerWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerWorker_DoWork);
            this.backgroundWorkerWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerWorker_RunWorkerCompleted);
            // 
            // FormUsers
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FormUsers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUsers_FormClosing);
            this.Load += new System.EventHandler(this.FormUsers_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button buttonResfresh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorkerWorker;
        private System.Windows.Forms.Button buttonColumnSelection;
        private System.Windows.Forms.Button buttonfromAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
    }
}