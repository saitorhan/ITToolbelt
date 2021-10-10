
using ITToolbelt.WinForms.Forms.UserAndGroups;

namespace ITToolbelt.WinForms.Forms.ComputersApps
{
    partial class FormApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApplications));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonResfresh = new System.Windows.Forms.Button();
            this.buttonColumnSelection = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewApplications = new System.Windows.Forms.DataGridView();
            this.applicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBarStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.backgroundWorkerWorker = new System.ComponentModel.BackgroundWorker();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.builtTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonResfresh);
            this.panel1.Controls.Add(this.buttonColumnSelection);
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonAdd);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
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
            this.groupBox1.Controls.Add(this.dataGridViewApplications);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // dataGridViewApplications
            // 
            this.dataGridViewApplications.AllowUserToAddRows = false;
            this.dataGridViewApplications.AllowUserToDeleteRows = false;
            this.dataGridViewApplications.AllowUserToOrderColumns = true;
            this.dataGridViewApplications.AutoGenerateColumns = false;
            this.dataGridViewApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewApplications.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.builtTypeDataGridViewTextBoxColumn});
            this.dataGridViewApplications.DataSource = this.applicationBindingSource;
            resources.ApplyResources(this.dataGridViewApplications, "dataGridViewApplications");
            this.dataGridViewApplications.Name = "dataGridViewApplications";
            this.dataGridViewApplications.ReadOnly = true;
            this.dataGridViewApplications.Tag = "60CC88BD16444FDF8DB1C84C9E7C23D4";
            // 
            // applicationBindingSource
            // 
            this.applicationBindingSource.DataSource = typeof(ITToolbelt.Entity.Db.Application);
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            resources.ApplyResources(this.publisherDataGridViewTextBoxColumn, "publisherDataGridViewTextBoxColumn");
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "Version";
            resources.ApplyResources(this.versionDataGridViewTextBoxColumn, "versionDataGridViewTextBoxColumn");
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            this.versionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // builtTypeDataGridViewTextBoxColumn
            // 
            this.builtTypeDataGridViewTextBoxColumn.DataPropertyName = "BuiltType";
            resources.ApplyResources(this.builtTypeDataGridViewTextBoxColumn, "builtTypeDataGridViewTextBoxColumn");
            this.builtTypeDataGridViewTextBoxColumn.Name = "builtTypeDataGridViewTextBoxColumn";
            this.builtTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormApplications
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FormApplications";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUsers_FormClosing);
            this.Load += new System.EventHandler(this.FormUsers_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewApplications;
        private System.Windows.Forms.BindingSource applicationBindingSource;
        private System.Windows.Forms.Button buttonResfresh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorkerWorker;
        private System.Windows.Forms.Button buttonColumnSelection;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn builtTypeDataGridViewTextBoxColumn;
    }
}