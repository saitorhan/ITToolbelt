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
    public partial class FormGetUsers : Form
    {
        private List<int> Ids { get; }
        public List<User> Users { get; set; }
        public FormGetUsers(List<int> ids)
        {
            Ids = ids;
            InitializeComponent();
            UserManager groupManager = new UserManager(GlobalVariables.ConnectInfo);
            List<User> groups = groupManager.GetAll();
            usersBindingSource.DataSource = groups;

            Users = new List<User>();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridViewGroups.SelectedRows;
            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                if (selectedRow.DataBoundItem is User)
                {
                    Users.Add(selectedRow.DataBoundItem as User);
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
                    User item = row.DataBoundItem as User;
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
