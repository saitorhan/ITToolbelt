
namespace ITToolbelt.WinForms.Forms.MainAppForms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userGoupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBACockpitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turkishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userGoupsToolStripMenuItem,
            this.dBACockpitToolStripMenuItem,
            this.settingsToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // userGoupsToolStripMenuItem
            // 
            this.userGoupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem,
            this.groupsToolStripMenuItem});
            this.userGoupsToolStripMenuItem.Name = "userGoupsToolStripMenuItem";
            resources.ApplyResources(this.userGoupsToolStripMenuItem, "userGoupsToolStripMenuItem");
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            resources.ApplyResources(this.usersToolStripMenuItem, "usersToolStripMenuItem");
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            resources.ApplyResources(this.groupsToolStripMenuItem, "groupsToolStripMenuItem");
            this.groupsToolStripMenuItem.Click += new System.EventHandler(this.groupsToolStripMenuItem_Click);
            // 
            // dBACockpitToolStripMenuItem
            // 
            this.dBACockpitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionsToolStripMenuItem,
            this.indexToolStripMenuItem});
            this.dBACockpitToolStripMenuItem.Name = "dBACockpitToolStripMenuItem";
            resources.ApplyResources(this.dBACockpitToolStripMenuItem, "dBACockpitToolStripMenuItem");
            // 
            // connectionsToolStripMenuItem
            // 
            this.connectionsToolStripMenuItem.Name = "connectionsToolStripMenuItem";
            resources.ApplyResources(this.connectionsToolStripMenuItem, "connectionsToolStripMenuItem");
            this.connectionsToolStripMenuItem.Click += new System.EventHandler(this.connectionsToolStripMenuItem_Click);
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            resources.ApplyResources(this.indexToolStripMenuItem, "indexToolStripMenuItem");
            this.indexToolStripMenuItem.Click += new System.EventHandler(this.indexToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.turkishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Tag = "en-EN";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.setLanguageMenu_Click);
            // 
            // turkishToolStripMenuItem
            // 
            this.turkishToolStripMenuItem.Name = "turkishToolStripMenuItem";
            resources.ApplyResources(this.turkishToolStripMenuItem, "turkishToolStripMenuItem");
            this.turkishToolStripMenuItem.Tag = "tr-Tr";
            this.turkishToolStripMenuItem.Click += new System.EventHandler(this.setLanguageMenu_Click);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dBACockpitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turkishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userGoupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
    }
}

