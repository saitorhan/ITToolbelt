
namespace ITToolbelt.WinForms.Forms.MainAppForms
{
    partial class FormMetadatas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMetadatas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonResfresh = new System.Windows.Forms.Button();
            this.buttonColumnSelection = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewMetadatas = new System.Windows.Forms.DataGridView();
            this.metadataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBarStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.backgroundWorkerWorker = new System.ComponentModel.BackgroundWorker();
            this.metadataTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMetadatas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metadataBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.buttonResfresh);
            this.panel1.Controls.Add(this.buttonColumnSelection);
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Controls.Add(this.buttonUpdate);
            this.panel1.Controls.Add(this.buttonAdd);
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
            this.groupBox1.Controls.Add(this.dataGridViewMetadatas);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // dataGridViewMetadatas
            // 
            resources.ApplyResources(this.dataGridViewMetadatas, "dataGridViewMetadatas");
            this.dataGridViewMetadatas.AllowUserToAddRows = false;
            this.dataGridViewMetadatas.AllowUserToDeleteRows = false;
            this.dataGridViewMetadatas.AllowUserToOrderColumns = true;
            this.dataGridViewMetadatas.AutoGenerateColumns = false;
            this.dataGridViewMetadatas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMetadatas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.metadataTypeDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn});
            this.dataGridViewMetadatas.DataSource = this.metadataBindingSource;
            this.dataGridViewMetadatas.Name = "dataGridViewMetadatas";
            this.dataGridViewMetadatas.ReadOnly = true;
            this.dataGridViewMetadatas.Tag = "29583F4D9E884C65B5CAA2666C490968";
            // 
            // metadataBindingSource
            // 
            this.metadataBindingSource.DataSource = typeof(ITToolbelt.Entity.Db.Metadata);
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
            // metadataTypeDataGridViewTextBoxColumn
            // 
            this.metadataTypeDataGridViewTextBoxColumn.DataPropertyName = "MetadataType";
            resources.ApplyResources(this.metadataTypeDataGridViewTextBoxColumn, "metadataTypeDataGridViewTextBoxColumn");
            this.metadataTypeDataGridViewTextBoxColumn.Name = "metadataTypeDataGridViewTextBoxColumn";
            this.metadataTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            resources.ApplyResources(this.valueDataGridViewTextBoxColumn, "valueDataGridViewTextBoxColumn");
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormMetadatas
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "FormMetadatas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUsers_FormClosing);
            this.Load += new System.EventHandler(this.FormUsers_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMetadatas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metadataBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewMetadatas;
        private System.Windows.Forms.BindingSource metadataBindingSource;
        private System.Windows.Forms.Button buttonResfresh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorkerWorker;
        private System.Windows.Forms.Button buttonColumnSelection;
        private System.Windows.Forms.DataGridViewTextBoxColumn metadataTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
    }
}