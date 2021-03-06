using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITToolbelt.Bll.Managers;
using ITToolbelt.Entity.Db;

namespace ITToolbelt.WinForms.Forms.UserAndGroups
{
    public partial class FormGetGroups : Form
    {
        private List<int> Ids { get; }
        public List<Group> Groups { get; set; }
        public FormGetGroups(List<int> ids)
        {
            Ids = ids;
            InitializeComponent();
            GroupManager groupManager = new GroupManager(GlobalVariables.ConnectInfo);
            List<Group> groups = groupManager.GetAll();
            groupBindingSource.DataSource = groups;

            Groups = new List<Group>();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridViewGroups.SelectedRows;
            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                if (selectedRow.DataBoundItem is Group)
                {
                    Groups.Add(selectedRow.DataBoundItem as Group);
                }
            }

            Close();
        }

        private void FormGetGroups_Load(object sender, EventArgs e)
        {
            if (Ids == null)
            {
                return;
            }

            foreach (int id in Ids)
            {
                foreach (DataGridViewRow row in dataGridViewGroups.Rows)
                {
                    Group item = row.DataBoundItem as Group;
                    if (item.Id == id)
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }
        }
    }
}
