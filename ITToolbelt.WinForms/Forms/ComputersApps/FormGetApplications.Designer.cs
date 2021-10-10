
using ITToolbelt.WinForms.Forms.UserAndGroups;

namespace ITToolbelt.WinForms.Forms.ComputersApps
{
    partial class FormGetApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGetApplications));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOk = new System.Windows.Forms.Button();
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.appsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.builtTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.buttonOk);
            this.panel1.Name = "panel1";
            // 
            // buttonOk
            // 
            resources.ApplyResources(this.buttonOk, "buttonOk");
            this.buttonOk.Image = global::ITToolbelt.WinForms.Properties.Resources.accept;
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // dataGridViewGroups
            // 
            resources.ApplyResources(this.dataGridViewGroups, "dataGridViewGroups");
            this.dataGridViewGroups.AllowUserToAddRows = false;
            this.dataGridViewGroups.AllowUserToDeleteRows = false;
            this.dataGridViewGroups.AutoGenerateColumns = false;
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.builtTypeDataGridViewTextBoxColumn});
            this.dataGridViewGroups.DataSource = this.appsBindingSource;
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.ReadOnly = true;
            // 
            // appsBindingSource
            // 
            this.appsBindingSource.DataSource = typeof(ITToolbelt.Entity.Db.Application);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
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
            // FormGetApplications
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridViewGroups);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGetApplications";
            this.Load += new System.EventHandler(this.FormGetGroups_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.BindingSource appsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn builtTypeDataGridViewTextBoxColumn;
    }
}