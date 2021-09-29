
namespace ITToolbelt.WinForms.Forms.DBAForms
{
    partial class FormMsSqlLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMsSqlLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarConnection = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.comboBoxAuthType = new System.Windows.Forms.ComboBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.textBoxConName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxServerInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxInfo.SuspendLayout();
            this.groupBoxServerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // progressBarConnection
            // 
            resources.ApplyResources(this.progressBarConnection, "progressBarConnection");
            this.progressBarConnection.MarqueeAnimationSpeed = 50;
            this.progressBarConnection.Name = "progressBarConnection";
            this.progressBarConnection.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
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
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBoxServerName
            // 
            resources.ApplyResources(this.textBoxServerName, "textBoxServerName");
            this.textBoxServerName.Name = "textBoxServerName";
            // 
            // comboBoxAuthType
            // 
            resources.ApplyResources(this.comboBoxAuthType, "comboBoxAuthType");
            this.comboBoxAuthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAuthType.FormattingEnabled = true;
            this.comboBoxAuthType.Items.AddRange(new object[] {
            resources.GetString("comboBoxAuthType.Items"),
            resources.GetString("comboBoxAuthType.Items1")});
            this.comboBoxAuthType.Name = "comboBoxAuthType";
            this.comboBoxAuthType.SelectedIndexChanged += new System.EventHandler(this.comboBoxAuthType_SelectedIndexChanged);
            // 
            // textBoxUserName
            // 
            resources.ApplyResources(this.textBoxUserName, "textBoxUserName");
            this.textBoxUserName.Name = "textBoxUserName";
            // 
            // textBoxPassword
            // 
            resources.ApplyResources(this.textBoxPassword, "textBoxPassword");
            this.textBoxPassword.Name = "textBoxPassword";
            // 
            // buttonHelp
            // 
            resources.ApplyResources(this.buttonHelp, "buttonHelp");
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonCancel
            // 
            resources.ApplyResources(this.buttonCancel, "buttonCancel");
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonConnect
            // 
            resources.ApplyResources(this.buttonConnect, "buttonConnect");
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // groupBoxInfo
            // 
            resources.ApplyResources(this.groupBoxInfo, "groupBoxInfo");
            this.groupBoxInfo.Controls.Add(this.textBoxConName);
            this.groupBoxInfo.Controls.Add(this.label6);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.TabStop = false;
            // 
            // textBoxConName
            // 
            resources.ApplyResources(this.textBoxConName, "textBoxConName");
            this.textBoxConName.Name = "textBoxConName";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // groupBoxServerInfo
            // 
            resources.ApplyResources(this.groupBoxServerInfo, "groupBoxServerInfo");
            this.groupBoxServerInfo.Controls.Add(this.label2);
            this.groupBoxServerInfo.Controls.Add(this.label3);
            this.groupBoxServerInfo.Controls.Add(this.label4);
            this.groupBoxServerInfo.Controls.Add(this.label5);
            this.groupBoxServerInfo.Controls.Add(this.textBoxServerName);
            this.groupBoxServerInfo.Controls.Add(this.textBoxPassword);
            this.groupBoxServerInfo.Controls.Add(this.comboBoxAuthType);
            this.groupBoxServerInfo.Controls.Add(this.textBoxUserName);
            this.groupBoxServerInfo.Name = "groupBoxServerInfo";
            this.groupBoxServerInfo.TabStop = false;
            // 
            // FormMsSqlLogin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxServerInfo);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.progressBarConnection);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMsSqlLogin";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.groupBoxServerInfo.ResumeLayout(false);
            this.groupBoxServerInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarConnection;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.ComboBox comboBoxAuthType;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.TextBox textBoxConName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxServerInfo;
    }
}