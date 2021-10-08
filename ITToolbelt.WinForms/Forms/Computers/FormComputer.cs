using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITToolbelt.Bll.Managers;
using ITToolbelt.Entity.Db;
using ITToolbelt.WinForms.ExtensionMethods;

namespace ITToolbelt.WinForms.Forms.Computers
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
            User user = comboBoxUser.SelectedItem as User;
            Computer.UserId = user?.Id;

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
