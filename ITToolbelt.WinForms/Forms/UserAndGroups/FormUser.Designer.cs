
namespace ITToolbelt.WinForms.Forms.UserAndGroups
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonRemoveGroup = new System.Windows.Forms.Button();
            this.buttonGroupAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
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
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
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
            // textBoxSurname
            // 
            resources.ApplyResources(this.textBoxSurname, "textBoxSurname");
            this.textBoxSurname.Name = "textBoxSurname";
            // 
            // textBoxMail
            // 
            resources.ApplyResources(this.textBoxMail, "textBoxMail");
            this.textBoxMail.Name = "textBoxMail";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBoxUsername
            // 
            resources.ApplyResources(this.textBoxUsername, "textBoxUsername");
            this.textBoxUsername.Name = "textBoxUsername";
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
            this.dataGridViewGroups.AllowUserToOrderColumns = true;
            this.dataGridViewGroups.AutoGenerateColumns = false;
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridViewGroups.DataSource = this.groupBindingSource;
            resources.ApplyResources(this.dataGridViewGroups, "dataGridViewGroups");
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            resources.ApplyResources(this.descriptionDataGridViewTextBoxColumn, "descriptionDataGridViewTextBoxColumn");
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(ITToolbelt.Entity.Db.Group);
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
            // FormUser
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUser";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.Button buttonGroupAdd;
        private System.Windows.Forms.Button buttonRemoveGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}