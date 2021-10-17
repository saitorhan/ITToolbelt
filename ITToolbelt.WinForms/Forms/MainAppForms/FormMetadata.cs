using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ITToolbelt.Bll.Managers;
using ITToolbelt.Entity.Db;
using ITToolbelt.Entity.Enum;
using ITToolbelt.WinForms.ExtensionMethods;

namespace ITToolbelt.WinForms.Forms.MainAppForms
{
    public partial class FormMetadata : Form
    {
        private Metadata Metadata;
        public FormMetadata()
        {
            InitializeComponent();

            Metadata = new Metadata();
            GetMetaTypes();
        }
        public FormMetadata(Metadata metadata)
        {
            InitializeComponent();

            Metadata = metadata;
            textBoxValue.Text = metadata.Value;

            GetMetaTypes();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Metadata.Value = textBoxValue.Text;
            Metadata.MetadataType = (MetadataType)comboBoxType.SelectedItem;

            MetadataManager metadataManager = new MetadataManager(GlobalVariables.ConnectInfo);
            Tuple<bool, List<string>> add = Metadata.Id > 0 ? metadataManager.Update(Metadata) : metadataManager.Add(Metadata);
            add.ShowDialog();
            if (add.Item1)
            {
                Close();
            }
        }

        private void GetMetaTypes()
        {
            List<MetadataType> metadatas = Enum.GetValues(typeof(MetadataType)).Cast<MetadataType>().ToList();
            comboBoxType.DataSource = metadatas;

            foreach (MetadataType item in comboBoxType.Items)
            {
                if (item != Metadata.MetadataType) continue;
                comboBoxType.SelectedItem = item;
                return;
            }
        }
    }
}
