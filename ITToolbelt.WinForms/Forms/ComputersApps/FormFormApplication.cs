using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ITToolbelt.Bll.Managers;
using ITToolbelt.Entity.Db;
using ITToolbelt.WinForms.ExtensionMethods;
using ITToolbelt.WinForms.Forms.UserAndGroups;
using Application = ITToolbelt.Entity.Db.Application;

namespace ITToolbelt.WinForms.Forms.ComputersApps
{
    public partial class FormApplication : Form
    {
        private Application Application;
        public FormApplication()
        {
            InitializeComponent();

            Application = new Application();
        }
        public FormApplication(Application application)
        {
            InitializeComponent();

            Application = application;
            textBoxName.Text = application.Name;

            UserManager groupManager = new UserManager(GlobalVariables.ConnectInfo);
            List<User> userGroups = groupManager.GetUserGroups(application.Id);
            groupsBindingSource.DataSource = userGroups;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Application.Name = textBoxName.Text;
            

            ApplicationManeger userManager = new ApplicationManeger(GlobalVariables.ConnectInfo);
            Tuple<bool, List<string>> add = Application.Id > 0 ? userManager.Update(Application) : userManager.Add(Application);
            add.ShowDialog();
            if (add.Item1)
            {
                Close();
            }
        }

        private void buttonGroupAdd_Click(object sender, EventArgs e)
        {
            List<User> users = groupsBindingSource.DataSource as List<User> ?? new List<User>();

            List<int> list = users.Select(g => g.Id).ToList();

            FormGetUsers formGetGroups = new FormGetUsers(list);
            formGetGroups.ShowDialog();


            foreach (User user in formGetGroups.Users)
            {
                if (users.All(g => g.Id != user.Id))
                {
                    users.Add(user);
                }
            }

            groupsBindingSource.DataSource = users;
            dataGridViewGroups.DataSource = null;
            dataGridViewGroups.DataSource = groupsBindingSource;
        }

        private void buttonRemoveGroup_Click(object sender, EventArgs e)
        {
            if (dataGridViewGroups.SelectedRows.Count == 0)
            {
                return;
            }

            User user = dataGridViewGroups.SelectedRows[0].DataBoundItem as User;
            if (user == null)
            {
                return;
            }

            List<User> users = groupsBindingSource.DataSource as List<User>;

            users.Remove(user);

            groupsBindingSource.DataSource = users;
            dataGridViewGroups.DataSource = null;
            dataGridViewGroups.DataSource = groupsBindingSource;
        }
    }
}
