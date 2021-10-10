﻿using System;
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

            ApplicationManeger applicationManeger = new ApplicationManeger(GlobalVariables.ConnectInfo);
            List<Group> applicationGroups = applicationManeger.GetApplicationGroups(application.Id);
            groupsBindingSource.DataSource = applicationGroups;
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
            List<Group> groups = groupsBindingSource.DataSource as List<Group> ?? new List<Group>();

            List<int> list = groups.Select(g => g.Id).ToList();

            FormGetGroups formGetGroups = new FormGetGroups(list);
            formGetGroups.ShowDialog();


            foreach (Group @group in formGetGroups.Groups)
            {
                if (groups.All(g => g.Id != @group.Id))
                {
                    groups.Add(@group);
                }
            }

            groupsBindingSource.DataSource = groups;
            dataGridViewGroups.DataSource = null;
            dataGridViewGroups.DataSource = groupsBindingSource;
        }

        private void buttonRemoveGroup_Click(object sender, EventArgs e)
        {
            if (dataGridViewGroups.SelectedRows.Count == 0)
            {
                return;
            }

            Group @group = dataGridViewGroups.SelectedRows[0].DataBoundItem as Group;
            if (@group == null)
            {
                return;
            }

            List<Group> groups = groupsBindingSource.DataSource as List<Group>;

            groups.Remove(@group);

            groupsBindingSource.DataSource = groups;
            dataGridViewGroups.DataSource = null;
            dataGridViewGroups.DataSource = groupsBindingSource;
        }
    }
}
