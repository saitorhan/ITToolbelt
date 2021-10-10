using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ITToolbelt.Bll.Managers;
using ITToolbelt.Entity.Db;
using Application = ITToolbelt.Entity.Db.Application;

namespace ITToolbelt.WinForms.Forms.ComputersApps
{
    public partial class FormGetApplications : Form
    {
        private List<int> Ids { get; }
        public List<Application> Applications { get; set; }
        public FormGetApplications(List<int> ids)
        {
            Ids = ids;
            InitializeComponent();
            ApplicationManeger groupManager = new ApplicationManeger(GlobalVariables.ConnectInfo);
            List<Application> groups = groupManager.GetAll();
            appsBindingSource.DataSource = groups;

            Applications = new List<Application>();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection selectedRows = dataGridViewGroups.SelectedRows;
            foreach (DataGridViewRow selectedRow in selectedRows)
            {
                if (selectedRow.DataBoundItem is Application)
                {
                    Applications.Add(selectedRow.DataBoundItem as Application);
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
                    Application item = row.DataBoundItem as Application;
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
