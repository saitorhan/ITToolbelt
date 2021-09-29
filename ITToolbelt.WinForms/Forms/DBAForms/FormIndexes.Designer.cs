
namespace ITToolbelt.WinForms.Forms.DBAForms
{
    partial class FormIndexes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIndexes));
            this.treeViewConnections = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonGetColumns = new System.Windows.Forms.Button();
            this.buttonDisable = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.groupBoxIndex = new System.Windows.Forms.GroupBox();
            this.dataGridViewIndexes = new System.Windows.Forms.DataGridView();
            this.indexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBarStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBoxColumns = new System.Windows.Forms.GroupBox();
            this.groupBoxInclude = new System.Windows.Forms.GroupBox();
            this.listViewIncludes = new System.Windows.Forms.ListView();
            this.columnHeaderInclude = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderIType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxIndexColumns = new System.Windows.Forms.GroupBox();
            this.listViewColumns = new System.Windows.Forms.ListView();
            this.columnHeaderColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sort = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.schemaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ındexNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fragmantationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pageCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBoxIndex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndexes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexBindingSource)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxColumns.SuspendLayout();
            this.groupBoxInclude.SuspendLayout();
            this.groupBoxIndexColumns.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewConnections
            // 
            resources.ApplyResources(this.treeViewConnections, "treeViewConnections");
            this.treeViewConnections.Name = "treeViewConnections";
            this.treeViewConnections.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewConnections_NodeMouseDoubleClick);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.buttonGetColumns);
            this.panel1.Controls.Add(this.buttonDisable);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Name = "panel1";
            // 
            // buttonGetColumns
            // 
            resources.ApplyResources(this.buttonGetColumns, "buttonGetColumns");
            this.buttonGetColumns.Image = global::ITToolbelt.WinForms.Properties.Resources.key;
            this.buttonGetColumns.Name = "buttonGetColumns";
            this.buttonGetColumns.UseVisualStyleBackColor = true;
            this.buttonGetColumns.Click += new System.EventHandler(this.buttonGetColumns_Click);
            // 
            // buttonDisable
            // 
            resources.ApplyResources(this.buttonDisable, "buttonDisable");
            this.buttonDisable.Image = global::ITToolbelt.WinForms.Properties.Resources.block;
            this.buttonDisable.Name = "buttonDisable";
            this.buttonDisable.UseVisualStyleBackColor = true;
            this.buttonDisable.Click += new System.EventHandler(this.buttonDisable_Click);
            // 
            // buttonRefresh
            // 
            resources.ApplyResources(this.buttonRefresh, "buttonRefresh");
            this.buttonRefresh.Image = global::ITToolbelt.WinForms.Properties.Resources.refresh;
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // groupBoxIndex
            // 
            resources.ApplyResources(this.groupBoxIndex, "groupBoxIndex");
            this.groupBoxIndex.Controls.Add(this.dataGridViewIndexes);
            this.groupBoxIndex.Name = "groupBoxIndex";
            this.groupBoxIndex.TabStop = false;
            // 
            // dataGridViewIndexes
            // 
            resources.ApplyResources(this.dataGridViewIndexes, "dataGridViewIndexes");
            this.dataGridViewIndexes.AllowUserToAddRows = false;
            this.dataGridViewIndexes.AllowUserToDeleteRows = false;
            this.dataGridViewIndexes.AllowUserToOrderColumns = true;
            this.dataGridViewIndexes.AutoGenerateColumns = false;
            this.dataGridViewIndexes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIndexes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.schemaDataGridViewTextBoxColumn,
            this.tableDataGridViewTextBoxColumn,
            this.ındexNameDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.fragmantationDataGridViewTextBoxColumn,
            this.pageCountDataGridViewTextBoxColumn});
            this.dataGridViewIndexes.DataSource = this.indexBindingSource;
            this.dataGridViewIndexes.Name = "dataGridViewIndexes";
            this.dataGridViewIndexes.ReadOnly = true;
            this.dataGridViewIndexes.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewIndexes_DataError);
            this.dataGridViewIndexes.SelectionChanged += new System.EventHandler(this.dataGridViewIndexes_SelectionChanged);
            // 
            // indexBindingSource
            // 
            this.indexBindingSource.DataSource = typeof(ITToolbelt.Entity.EntityClass.Index);
            // 
            // statusStrip
            // 
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBarStatus});
            this.statusStrip.Name = "statusStrip";
            // 
            // toolStripProgressBarStatus
            // 
            resources.ApplyResources(this.toolStripProgressBarStatus, "toolStripProgressBarStatus");
            this.toolStripProgressBarStatus.Name = "toolStripProgressBarStatus";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Name = "panel2";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.treeViewConnections);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // groupBoxColumns
            // 
            resources.ApplyResources(this.groupBoxColumns, "groupBoxColumns");
            this.groupBoxColumns.Controls.Add(this.groupBoxInclude);
            this.groupBoxColumns.Controls.Add(this.groupBoxIndexColumns);
            this.groupBoxColumns.Name = "groupBoxColumns";
            this.groupBoxColumns.TabStop = false;
            // 
            // groupBoxInclude
            // 
            resources.ApplyResources(this.groupBoxInclude, "groupBoxInclude");
            this.groupBoxInclude.Controls.Add(this.listViewIncludes);
            this.groupBoxInclude.Name = "groupBoxInclude";
            this.groupBoxInclude.TabStop = false;
            // 
            // listViewIncludes
            // 
            resources.ApplyResources(this.listViewIncludes, "listViewIncludes");
            this.listViewIncludes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderInclude,
            this.columnHeaderIType});
            this.listViewIncludes.GridLines = true;
            this.listViewIncludes.HideSelection = false;
            this.listViewIncludes.Name = "listViewIncludes";
            this.listViewIncludes.UseCompatibleStateImageBehavior = false;
            this.listViewIncludes.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderInclude
            // 
            resources.ApplyResources(this.columnHeaderInclude, "columnHeaderInclude");
            // 
            // columnHeaderIType
            // 
            resources.ApplyResources(this.columnHeaderIType, "columnHeaderIType");
            // 
            // groupBoxIndexColumns
            // 
            resources.ApplyResources(this.groupBoxIndexColumns, "groupBoxIndexColumns");
            this.groupBoxIndexColumns.Controls.Add(this.listViewColumns);
            this.groupBoxIndexColumns.Name = "groupBoxIndexColumns";
            this.groupBoxIndexColumns.TabStop = false;
            // 
            // listViewColumns
            // 
            resources.ApplyResources(this.listViewColumns, "listViewColumns");
            this.listViewColumns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderColumn,
            this.Sort,
            this.columnHeaderType});
            this.listViewColumns.GridLines = true;
            this.listViewColumns.HideSelection = false;
            this.listViewColumns.Name = "listViewColumns";
            this.listViewColumns.UseCompatibleStateImageBehavior = false;
            this.listViewColumns.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderColumn
            // 
            resources.ApplyResources(this.columnHeaderColumn, "columnHeaderColumn");
            // 
            // Sort
            // 
            resources.ApplyResources(this.Sort, "Sort");
            // 
            // columnHeaderType
            // 
            resources.ApplyResources(this.columnHeaderType, "columnHeaderType");
            // 
            // schemaDataGridViewTextBoxColumn
            // 
            this.schemaDataGridViewTextBoxColumn.DataPropertyName = "Schema";
            resources.ApplyResources(this.schemaDataGridViewTextBoxColumn, "schemaDataGridViewTextBoxColumn");
            this.schemaDataGridViewTextBoxColumn.Name = "schemaDataGridViewTextBoxColumn";
            this.schemaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tableDataGridViewTextBoxColumn
            // 
            this.tableDataGridViewTextBoxColumn.DataPropertyName = "Table";
            resources.ApplyResources(this.tableDataGridViewTextBoxColumn, "tableDataGridViewTextBoxColumn");
            this.tableDataGridViewTextBoxColumn.Name = "tableDataGridViewTextBoxColumn";
            this.tableDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ındexNameDataGridViewTextBoxColumn
            // 
            this.ındexNameDataGridViewTextBoxColumn.DataPropertyName = "IndexName";
            resources.ApplyResources(this.ındexNameDataGridViewTextBoxColumn, "ındexNameDataGridViewTextBoxColumn");
            this.ındexNameDataGridViewTextBoxColumn.Name = "ındexNameDataGridViewTextBoxColumn";
            this.ındexNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            resources.ApplyResources(this.stateDataGridViewTextBoxColumn, "stateDataGridViewTextBoxColumn");
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fragmantationDataGridViewTextBoxColumn
            // 
            this.fragmantationDataGridViewTextBoxColumn.DataPropertyName = "Fragmantation";
            resources.ApplyResources(this.fragmantationDataGridViewTextBoxColumn, "fragmantationDataGridViewTextBoxColumn");
            this.fragmantationDataGridViewTextBoxColumn.Name = "fragmantationDataGridViewTextBoxColumn";
            this.fragmantationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pageCountDataGridViewTextBoxColumn
            // 
            this.pageCountDataGridViewTextBoxColumn.DataPropertyName = "PageCount";
            resources.ApplyResources(this.pageCountDataGridViewTextBoxColumn, "pageCountDataGridViewTextBoxColumn");
            this.pageCountDataGridViewTextBoxColumn.Name = "pageCountDataGridViewTextBoxColumn";
            this.pageCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormIndexes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxIndex);
            this.Controls.Add(this.groupBoxColumns);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormIndexes";
            this.panel1.ResumeLayout(false);
            this.groupBoxIndex.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIndexes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexBindingSource)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBoxColumns.ResumeLayout(false);
            this.groupBoxInclude.ResumeLayout(false);
            this.groupBoxIndexColumns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewConnections;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.GroupBox groupBoxIndex;
        private System.Windows.Forms.DataGridView dataGridViewIndexes;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource indexBindingSource;
        private System.Windows.Forms.Button buttonDisable;
        private System.Windows.Forms.GroupBox groupBoxColumns;
        private System.Windows.Forms.GroupBox groupBoxInclude;
        private System.Windows.Forms.ListView listViewIncludes;
        private System.Windows.Forms.GroupBox groupBoxIndexColumns;
        private System.Windows.Forms.ListView listViewColumns;
        private System.Windows.Forms.Button buttonGetColumns;
        private System.Windows.Forms.ColumnHeader columnHeaderColumn;
        private System.Windows.Forms.ColumnHeader Sort;
        private System.Windows.Forms.ColumnHeader columnHeaderInclude;
        private System.Windows.Forms.ColumnHeader columnHeaderIType;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.DataGridViewTextBoxColumn schemaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ındexNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fragmantationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pageCountDataGridViewTextBoxColumn;
    }
}