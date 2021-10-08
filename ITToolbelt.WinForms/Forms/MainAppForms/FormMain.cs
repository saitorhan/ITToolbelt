using System.Linq;
using System.Windows.Forms;
using ITToolbelt.Shared;
using ITToolbelt.WinForms.Forms.Computers;
using ITToolbelt.WinForms.Forms.DBAForms;
using ITToolbelt.WinForms.Forms.UserAndGroups;
using ITToolbelt.WinForms.Properties;

namespace ITToolbelt.WinForms.Forms.MainAppForms
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void connectionsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form form = new FormConnections();
            OpenForm(form);
        }

        private void OpenForm(Form f)
        {
            Form form = f;

            Form existForm = MdiChildren.FirstOrDefault(ff => ff.Name == form.Name);
            if (existForm == null)
            {
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
            else
            {
                existForm.BringToFront();
            }
        }

        private void indexToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form form = new FormIndexes();
            OpenForm(form);
        }

        private void setLanguageMenu_Click(object sender, System.EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            Settings.Default.Language = item.Tag.ToString();
            Settings.Default.Save();

            if (MessageBox.Show(Resource._008, Resource._009, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void usersToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form form = new FormUsers();
            OpenForm(form);
        }

        private void groupsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form form = new FormGroups();
            OpenForm(form);
        }

        private void computersToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Form form = new FormComputers();
            OpenForm(form);
        }
    }
}
