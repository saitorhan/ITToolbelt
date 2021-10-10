
namespace ITToolbelt.WinForms.Forms.DBAForms
{
    partial class FormConnections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConnections));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonColumnSelection = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAddMySql = new System.Windows.Forms.Button();
            this.buttonAddMsSql = new System.Windows.Forms.Button();
            this.groupBoxConnections = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBarConnections = new System.Windows.Forms.ToolStripProgressBar();
            this.dataGridViewConnections = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbServerTypeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionStringDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifiedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machineNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ınstanceNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productUpdateLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMajorVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMinorVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbServerTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.connectionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.groupBoxConnections.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnections)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.buttonColumnSelection);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonAddMySql);
            this.panel1.Controls.Add(this.buttonAddMsSql);
            this.panel1.Name = "panel1";
            // 
            // buttonColumnSelection
            // 
            resources.ApplyResources(this.buttonColumnSelection, "buttonColumnSelection");
            this.buttonColumnSelection.Image = global::ITToolbelt.WinForms.Properties.Resources.edit_page;
            this.buttonColumnSelection.Name = "buttonColumnSelection";
            this.buttonColumnSelection.UseVisualStyleBackColor = true;
            this.buttonColumnSelection.Click += new System.EventHandler(this.buttonColumnSelection_Click);
            // 
            // buttonRefresh
            // 
            resources.ApplyResources(this.buttonRefresh, "buttonRefresh");
            this.buttonRefresh.Image = global::ITToolbelt.WinForms.Properties.Resources.refresh;
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonDelete
            // 
            resources.ApplyResources(this.buttonDelete, "buttonDelete");
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            resources.ApplyResources(this.buttonEdit, "buttonEdit");
            this.buttonEdit.Image = global::ITToolbelt.WinForms.Properties.Resources.edit_page;
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAddMySql
            // 
            resources.ApplyResources(this.buttonAddMySql, "buttonAddMySql");
            this.buttonAddMySql.Image = global::ITToolbelt.WinForms.Properties.Resources.MySQL;
            this.buttonAddMySql.Name = "buttonAddMySql";
            this.buttonAddMySql.UseVisualStyleBackColor = true;
            this.buttonAddMySql.Click += new System.EventHandler(this.buttonAddMySql_Click);
            // 
            // buttonAddMsSql
            // 
            resources.ApplyResources(this.buttonAddMsSql, "buttonAddMsSql");
            this.buttonAddMsSql.Name = "buttonAddMsSql";
            this.buttonAddMsSql.UseVisualStyleBackColor = true;
            this.buttonAddMsSql.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxConnections
            // 
            resources.ApplyResources(this.groupBoxConnections, "groupBoxConnections");
            this.groupBoxConnections.Controls.Add(this.statusStrip1);
            this.groupBoxConnections.Controls.Add(this.dataGridViewConnections);
            this.groupBoxConnections.Name = "groupBoxConnections";
            this.groupBoxConnections.TabStop = false;
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBarConnections});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripProgressBarConnections
            // 
            resources.ApplyResources(this.toolStripProgressBarConnections, "toolStripProgressBarConnections");
            this.toolStripProgressBarConnections.Name = "toolStripProgressBarConnections";
            this.toolStripProgressBarConnections.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // dataGridViewConnections
            // 
            resources.ApplyResources(this.dataGridViewConnections, "dataGridViewConnections");
            this.dataGridViewConnections.AllowUserToAddRows = false;
            this.dataGridViewConnections.AllowUserToDeleteRows = false;
            this.dataGridViewConnections.AllowUserToOrderColumns = true;
            this.dataGridViewConnections.AutoGenerateColumns = false;
            this.dataGridViewConnections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConnections.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.dbServerTypeCodeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.connectionStringDataGridViewTextBoxColumn,
            this.createDateDataGridViewTextBoxColumn,
            this.modifiedDateDataGridViewTextBoxColumn,
            this.machineNameDataGridViewTextBoxColumn,
            this.serverNameDataGridViewTextBoxColumn,
            this.ınstanceNameDataGridViewTextBoxColumn,
            this.editionDataGridViewTextBoxColumn,
            this.productLevelDataGridViewTextBoxColumn,
            this.productUpdateLevelDataGridViewTextBoxColumn,
            this.productVersionDataGridViewTextBoxColumn,
            this.collationDataGridViewTextBoxColumn,
            this.productMajorVersionDataGridViewTextBoxColumn,
            this.productMinorVersionDataGridViewTextBoxColumn,
            this.dbServerTypeDataGridViewTextBoxColumn,
            this.connectionInfoDataGridViewTextBoxColumn});
            this.dataGridViewConnections.DataSource = this.connectionBindingSource;
            this.dataGridViewConnections.Name = "dataGridViewConnections";
            this.dataGridViewConnections.ReadOnly = true;
            this.dataGridViewConnections.Tag = "93ACC9322D75453D8B4BC4B7121C63EE";
            this.dataGridViewConnections.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewConnections_RowPrePaint);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            resources.ApplyResources(this.ıdDataGridViewTextBoxColumn, "ıdDataGridViewTextBoxColumn");
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dbServerTypeCodeDataGridViewTextBoxColumn
            // 
            this.dbServerTypeCodeDataGridViewTextBoxColumn.DataPropertyName = "DbServerTypeCode";
            resources.ApplyResources(this.dbServerTypeCodeDataGridViewTextBoxColumn, "dbServerTypeCodeDataGridViewTextBoxColumn");
            this.dbServerTypeCodeDataGridViewTextBoxColumn.Name = "dbServerTypeCodeDataGridViewTextBoxColumn";
            this.dbServerTypeCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // connectionStringDataGridViewTextBoxColumn
            // 
            this.connectionStringDataGridViewTextBoxColumn.DataPropertyName = "ConnectionString";
            resources.ApplyResources(this.connectionStringDataGridViewTextBoxColumn, "connectionStringDataGridViewTextBoxColumn");
            this.connectionStringDataGridViewTextBoxColumn.Name = "connectionStringDataGridViewTextBoxColumn";
            this.connectionStringDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createDateDataGridViewTextBoxColumn
            // 
            this.createDateDataGridViewTextBoxColumn.DataPropertyName = "CreateDate";
            resources.ApplyResources(this.createDateDataGridViewTextBoxColumn, "createDateDataGridViewTextBoxColumn");
            this.createDateDataGridViewTextBoxColumn.Name = "createDateDataGridViewTextBoxColumn";
            this.createDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modifiedDateDataGridViewTextBoxColumn
            // 
            this.modifiedDateDataGridViewTextBoxColumn.DataPropertyName = "ModifiedDate";
            resources.ApplyResources(this.modifiedDateDataGridViewTextBoxColumn, "modifiedDateDataGridViewTextBoxColumn");
            this.modifiedDateDataGridViewTextBoxColumn.Name = "modifiedDateDataGridViewTextBoxColumn";
            this.modifiedDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // machineNameDataGridViewTextBoxColumn
            // 
            this.machineNameDataGridViewTextBoxColumn.DataPropertyName = "MachineName";
            resources.ApplyResources(this.machineNameDataGridViewTextBoxColumn, "machineNameDataGridViewTextBoxColumn");
            this.machineNameDataGridViewTextBoxColumn.Name = "machineNameDataGridViewTextBoxColumn";
            this.machineNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // serverNameDataGridViewTextBoxColumn
            // 
            this.serverNameDataGridViewTextBoxColumn.DataPropertyName = "ServerName";
            resources.ApplyResources(this.serverNameDataGridViewTextBoxColumn, "serverNameDataGridViewTextBoxColumn");
            this.serverNameDataGridViewTextBoxColumn.Name = "serverNameDataGridViewTextBoxColumn";
            this.serverNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ınstanceNameDataGridViewTextBoxColumn
            // 
            this.ınstanceNameDataGridViewTextBoxColumn.DataPropertyName = "InstanceName";
            resources.ApplyResources(this.ınstanceNameDataGridViewTextBoxColumn, "ınstanceNameDataGridViewTextBoxColumn");
            this.ınstanceNameDataGridViewTextBoxColumn.Name = "ınstanceNameDataGridViewTextBoxColumn";
            this.ınstanceNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // editionDataGridViewTextBoxColumn
            // 
            this.editionDataGridViewTextBoxColumn.DataPropertyName = "Edition";
            resources.ApplyResources(this.editionDataGridViewTextBoxColumn, "editionDataGridViewTextBoxColumn");
            this.editionDataGridViewTextBoxColumn.Name = "editionDataGridViewTextBoxColumn";
            this.editionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productLevelDataGridViewTextBoxColumn
            // 
            this.productLevelDataGridViewTextBoxColumn.DataPropertyName = "ProductLevel";
            resources.ApplyResources(this.productLevelDataGridViewTextBoxColumn, "productLevelDataGridViewTextBoxColumn");
            this.productLevelDataGridViewTextBoxColumn.Name = "productLevelDataGridViewTextBoxColumn";
            this.productLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productUpdateLevelDataGridViewTextBoxColumn
            // 
            this.productUpdateLevelDataGridViewTextBoxColumn.DataPropertyName = "ProductUpdateLevel";
            resources.ApplyResources(this.productUpdateLevelDataGridViewTextBoxColumn, "productUpdateLevelDataGridViewTextBoxColumn");
            this.productUpdateLevelDataGridViewTextBoxColumn.Name = "productUpdateLevelDataGridViewTextBoxColumn";
            this.productUpdateLevelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productVersionDataGridViewTextBoxColumn
            // 
            this.productVersionDataGridViewTextBoxColumn.DataPropertyName = "ProductVersion";
            resources.ApplyResources(this.productVersionDataGridViewTextBoxColumn, "productVersionDataGridViewTextBoxColumn");
            this.productVersionDataGridViewTextBoxColumn.Name = "productVersionDataGridViewTextBoxColumn";
            this.productVersionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // collationDataGridViewTextBoxColumn
            // 
            this.collationDataGridViewTextBoxColumn.DataPropertyName = "Collation";
            resources.ApplyResources(this.collationDataGridViewTextBoxColumn, "collationDataGridViewTextBoxColumn");
            this.collationDataGridViewTextBoxColumn.Name = "collationDataGridViewTextBoxColumn";
            this.collationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productMajorVersionDataGridViewTextBoxColumn
            // 
            this.productMajorVersionDataGridViewTextBoxColumn.DataPropertyName = "ProductMajorVersion";
            resources.ApplyResources(this.productMajorVersionDataGridViewTextBoxColumn, "productMajorVersionDataGridViewTextBoxColumn");
            this.productMajorVersionDataGridViewTextBoxColumn.Name = "productMajorVersionDataGridViewTextBoxColumn";
            this.productMajorVersionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productMinorVersionDataGridViewTextBoxColumn
            // 
            this.productMinorVersionDataGridViewTextBoxColumn.DataPropertyName = "ProductMinorVersion";
            resources.ApplyResources(this.productMinorVersionDataGridViewTextBoxColumn, "productMinorVersionDataGridViewTextBoxColumn");
            this.productMinorVersionDataGridViewTextBoxColumn.Name = "productMinorVersionDataGridViewTextBoxColumn";
            this.productMinorVersionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dbServerTypeDataGridViewTextBoxColumn
            // 
            this.dbServerTypeDataGridViewTextBoxColumn.DataPropertyName = "DbServerType";
            resources.ApplyResources(this.dbServerTypeDataGridViewTextBoxColumn, "dbServerTypeDataGridViewTextBoxColumn");
            this.dbServerTypeDataGridViewTextBoxColumn.Name = "dbServerTypeDataGridViewTextBoxColumn";
            this.dbServerTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // connectionInfoDataGridViewTextBoxColumn
            // 
            this.connectionInfoDataGridViewTextBoxColumn.DataPropertyName = "ConnectionInfo";
            resources.ApplyResources(this.connectionInfoDataGridViewTextBoxColumn, "connectionInfoDataGridViewTextBoxColumn");
            this.connectionInfoDataGridViewTextBoxColumn.Name = "connectionInfoDataGridViewTextBoxColumn";
            this.connectionInfoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // connectionBindingSource
            // 
            this.connectionBindingSource.DataSource = typeof(ITToolbelt.Entity.Db.Connection);
            // 
            // FormConnections
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxConnections);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConnections";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConnections_FormClosing);
            this.Load += new System.EventHandler(this.FormConnections_Load);
            this.panel1.ResumeLayout(false);
            this.groupBoxConnections.ResumeLayout(false);
            this.groupBoxConnections.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnections)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connectionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAddMsSql;
        private System.Windows.Forms.GroupBox groupBoxConnections;
        private System.Windows.Forms.DataGridView dataGridViewConnections;
        private System.Windows.Forms.BindingSource connectionBindingSource;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonColumnSelection;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarConnections;
        private System.Windows.Forms.Button buttonAddMySql;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbServerTypeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionStringDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifiedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn machineNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ınstanceNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productUpdateLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMajorVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMinorVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dbServerTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn connectionInfoDataGridViewTextBoxColumn;
    }
}