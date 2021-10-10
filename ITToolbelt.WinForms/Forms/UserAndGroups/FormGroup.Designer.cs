
namespace ITToolbelt.WinForms.Forms.UserAndGroups
{
    partial class FormGroup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGroup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRemoveGroup = new System.Windows.Forms.Button();
            this.buttonGroupAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDesc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.fullnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewApplications = new System.Windows.Forms.DataGridView();
            this.applicationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.builtTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddApp = new System.Windows.Forms.Button();
            this.buttonRemoveApp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRemoveGroup);
            this.panel1.Controls.Add(this.buttonGroupAdd);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonSave);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // buttonRemoveGroup
            // 
            this.buttonRemoveGroup.Image = global::ITToolbelt.WinForms.Properties.Resources.delete_user;
            resources.ApplyResources(this.buttonRemoveGroup, "buttonRemoveGroup");
            this.buttonRemoveGroup.Name = "buttonRemoveGroup";
            this.buttonRemoveGroup.UseVisualStyleBackColor = true;
            this.buttonRemoveGroup.Click += new System.EventHandler(this.buttonRemoveGroup_Click);
            // 
            // buttonGroupAdd
            // 
            this.buttonGroupAdd.Image = global::ITToolbelt.WinForms.Properties.Resources.add_user;
            resources.ApplyResources(this.buttonGroupAdd, "buttonGroupAdd");
            this.buttonGroupAdd.Name = "buttonGroupAdd";
            this.buttonGroupAdd.UseVisualStyleBackColor = true;
            this.buttonGroupAdd.Click += new System.EventHandler(this.buttonGroupAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Image = global::ITToolbelt.WinForms.Properties.Resources.delete;
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Image = global::ITToolbelt.WinForms.Properties.Resources.accept;
            resources.ApplyResources(this.buttonSave, "buttonSave");
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBoxName
            // 
            resources.ApplyResources(this.textBoxName, "textBoxName");
            this.textBoxName.Name = "textBoxName";
            // 
            // textBoxDesc
            // 
            resources.ApplyResources(this.textBoxDesc, "textBoxDesc");
            this.textBoxDesc.Name = "textBoxDesc";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewGroups);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.AllowUserToAddRows = false;
            this.dataGridViewGroups.AllowUserToDeleteRows = false;
            this.dataGridViewGroups.AutoGenerateColumns = false;
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fullnameDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn});
            this.dataGridViewGroups.DataSource = this.userBindingSource;
            resources.ApplyResources(this.dataGridViewGroups, "dataGridViewGroups");
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.ReadOnly = true;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            this.fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            resources.ApplyResources(this.fullnameDataGridViewTextBoxColumn, "fullnameDataGridViewTextBoxColumn");
            this.fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            this.fullnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            resources.ApplyResources(this.usernameDataGridViewTextBoxColumn, "usernameDataGridViewTextBoxColumn");
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            resources.ApplyResources(this.mailDataGridViewTextBoxColumn, "mailDataGridViewTextBoxColumn");
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(ITToolbelt.Entity.Db.User);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewApplications);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
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
            this.versionDataGridViewTextBoxColumn,
            this.builtTypeDataGridViewTextBoxColumn});
            this.dataGridViewApplications.DataSource = this.applicationBindingSource;
            resources.ApplyResources(this.dataGridViewApplications, "dataGridViewApplications");
            this.dataGridViewApplications.Name = "dataGridViewApplications";
            this.dataGridViewApplications.ReadOnly = true;
            // 
            // applicationBindingSource
            // 
            this.applicationBindingSource.DataSource = typeof(ITToolbelt.Entity.Db.Application);
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
            // buttonAddApp
            // 
            resources.ApplyResources(this.buttonAddApp, "buttonAddApp");
            this.buttonAddApp.Name = "buttonAddApp";
            this.buttonAddApp.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveApp
            // 
            resources.ApplyResources(this.buttonRemoveApp, "buttonRemoveApp");
            this.buttonRemoveApp.Name = "buttonRemoveApp";
            this.buttonRemoveApp.UseVisualStyleBackColor = true;
            this.buttonRemoveApp.Click += new System.EventHandler(this.buttonRemoveApp_Click);
            // 
            // FormGroup
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRemoveApp);
            this.Controls.Add(this.buttonAddApp);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxDesc);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGroup";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewApplications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDesc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button buttonGroupAdd;
        private System.Windows.Forms.Button buttonRemoveGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewApplications;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn builtTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource applicationBindingSource;
        private System.Windows.Forms.Button buttonAddApp;
        private System.Windows.Forms.Button buttonRemoveApp;
    }
}