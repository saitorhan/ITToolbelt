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
        private Computer Group;
        public FormComputer()
        {
            InitializeComponent();

            Group = new Computer();
        }
        public FormComputer(Computer group)
        {
            InitializeComponent();

            Group = group;
            textBoxName.Text = group.Name;
            textBoxDesc.Text = group.Desc;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Group.Name = textBoxName.Text;
            Group.Desc = textBoxDesc.Text;
            
            ComputerManager userManager = new ComputerManager(GlobalVariables.ConnectInfo);
            Tuple<bool, List<string>> add = Group.Id > 0 ? userManager.Update(Group) : userManager.Add(Group);
            add.ShowDialog();
            if (add.Item1)
            {
                Close();
            }
        }
    }
}
