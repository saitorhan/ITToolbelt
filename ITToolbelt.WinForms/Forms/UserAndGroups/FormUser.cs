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
using ITToolbelt.WinForms.ExtensionMethods;

namespace ITToolbelt.WinForms.Forms.UserAndGroups
{
    public partial class FormUser : Form
    {
        private User User;
        public FormUser()
        {
            InitializeComponent();

            User = new User();
            GetComputers();
        }

        private void GetComputers()
        {
            ComputerManager computerManager = new ComputerManager(GlobalVariables.ConnectInfo);
            List<Computer> computers = computerManager.GetFreeComputers();
            computerBindingSource.DataSource = computers;

            if (User == null)
            {
                return;
            }

            List<Computer> userComputers = computerManager.GetUserComputers(User.Id);
            foreach (Computer computer in userComputers)
            {
                dataGridViewComputers.Rows.Add(computer.Id, computer.Name);
            }
        }

        public FormUser(User user)
        {
            InitializeComponent();

            User = user;
            textBoxName.Text = user.Firstname;
            textBoxSurname.Text = user.Surname;
            textBoxMail.Text = user.Mail;
            textBoxUsername.Text = user.Username;

            GroupManager groupManager = new GroupManager(GlobalVariables.ConnectInfo);
            List<Group> userGroups = groupManager.GetUserGroups(user.Id);
            groupBindingSource.DataSource = userGroups;

            GetComputers();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            User.Firstname = textBoxName.Text;
            User.Surname = textBoxSurname.Text;
            User.Mail = textBoxMail.Text;
            User.Username = textBoxUsername.Text;

            List<Group> groups = groupBindingSource.DataSource as List<Group>;
            if (groups != null)
            {
                User.UserGroups = new List<UserGroup>();
                foreach (Group group in groups)
                {
                    UserGroup userGroup = new UserGroup { GroupId = @group.Id };
                    if (User.Id > 0)
                    {
                        userGroup.UserId = User.Id;
                    }
                    User.UserGroups.Add(userGroup);
                }
            }

            UserManager userManager = new UserManager(GlobalVariables.ConnectInfo);
            Tuple<bool, List<string>> add = User.Id > 0 ? userManager.Update(User) : userManager.Add(User);
            add.ShowDialog();
            if (add.Item1)
            {
                Close();
            }
        }

        private void buttonGroupAdd_Click(object sender, EventArgs e)
        {
            List<Group> groups = groupBindingSource.DataSource as List<Group> ?? new List<Group>();

            List<int> list = groups.Select(g => g.Id).ToList();

            FormGetGroups formGetGroups = new FormGetGroups(list);
            formGetGroups.ShowDialog();


            foreach (Group selectedGroup in formGetGroups.Groups)
            {
                if (groups.All(g => g.Id != selectedGroup.Id))
                {
                    groups.Add(selectedGroup);
                }
            }

            groupBindingSource.DataSource = groups;
            dataGridViewGroups.DataSource = null;
            dataGridViewGroups.DataSource = groupBindingSource;
        }

        private void buttonRemoveGroup_Click(object sender, EventArgs e)
        {
            if (dataGridViewGroups.SelectedRows.Count == 0)
            {
                return;
            }

            Group item = dataGridViewGroups.SelectedRows[0].DataBoundItem as Group;
            if (item == null)
            {
                return;
            }

            List<Group> groups = groupBindingSource.DataSource as List<Group>;

            groups.Remove(item);

            groupBindingSource.DataSource = groups;
            dataGridViewGroups.DataSource = null;
            dataGridViewGroups.DataSource = groupBindingSource;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Computer selectedItem = comboBoxComputers.SelectedItem as Computer;
            if (selectedItem == null)
            {
                return;
            }

            foreach (DataGridViewRow row in dataGridViewComputers.Rows)
            {
                int id = (int)row.Cells[0].Value;
                if (selectedItem.Id == id)
                {
                    return;
                }
            }

            dataGridViewComputers.Rows.Add(selectedItem.Id, selectedItem.Name);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewComputers.SelectedRows.Count != 1)
            {
                return;
            }

            dataGridViewComputers.Rows.Remove(dataGridViewComputers.SelectedRows[0]);
        }
    }
}
