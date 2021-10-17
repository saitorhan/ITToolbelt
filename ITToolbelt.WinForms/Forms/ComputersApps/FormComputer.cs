using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ITToolbelt.Bll.Managers;
using ITToolbelt.Entity.Db;
using ITToolbelt.WinForms.ExtensionMethods;

namespace ITToolbelt.WinForms.Forms.ComputersApps
{
    public partial class FormComputer : Form
    {
        private Computer Computer;
        public FormComputer()
        {
            InitializeComponent();

            Computer = new Computer();
            GetUsers();
        }
        public FormComputer(Computer computer)
        {
            InitializeComponent();

            Computer = computer;
            textBoxName.Text = computer.Name;
            textBoxDesc.Text = computer.Desc;
            textBoxSerialNumber.Text = computer.SerialNumber;

            GetUsers();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Computer.Name = textBoxName.Text;
            Computer.Desc = textBoxDesc.Text;
            Computer.SerialNumber = textBoxSerialNumber.Text;
            User user = comboBoxUser.SelectedItem as User;
            Computer.UserId = user == null || user.Id < 0 ? (int?)null : user.Id;

            ComputerManager userManager = new ComputerManager(GlobalVariables.ConnectInfo);
            Tuple<bool, List<string>> add = Computer.Id > 0 ? userManager.Update(Computer) : userManager.Add(Computer);
            add.ShowDialog();
            if (add.Item1)
            {
                Close();
            }
        }

        private void GetUsers()
        {
            UserManager userManager = new UserManager(GlobalVariables.ConnectInfo);
            List<User> users = userManager.GetAll();
            users.Insert(0, new User{Id = -1, Firstname = String.Empty, Surname = String.Empty});
            userBindingSource.DataSource = users;

            if (Computer?.UserId == null) return;
            foreach (User item in comboBoxUser.Items)
            {
                if (item.Id != Computer.UserId) continue;
                comboBoxUser.SelectedItem = item;
                return;
            }
        }
    }
}
