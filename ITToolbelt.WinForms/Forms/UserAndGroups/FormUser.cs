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
        }
        public FormUser(User user)
        {
            InitializeComponent();

            User = user;
            textBoxName.Text = user.Firstname;
            textBoxSurname.Text = user.Surname;
            textBoxMail.Text = user.Mail;
            textBoxUsername.Text = user.Username;
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

            UserManager userManager = new UserManager(GlobalVariables.ConnectInfo);
            Tuple<bool, List<string>> add = User.Id > 0 ? userManager.Update(User) : userManager.Add(User);
            add.ShowDialog();
            if (add.Item1)
            {
                Close();
            }
        }
    }
}
