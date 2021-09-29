using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ITToolbelt.WinForms.ExtensionMethods
{
    public static class VisualControls
    {
        public static void StartStopMarque(this ProgressBar progressBar)
        {
            if (progressBar.Style != ProgressBarStyle.Marquee)
            {
                progressBar.Style = ProgressBarStyle.Marquee;
                progressBar.MarqueeAnimationSpeed = 50;
            }
            else
            {
                progressBar.Style = ProgressBarStyle.Continuous;
                progressBar.MarqueeAnimationSpeed = 0;
            }
        }
        public static void StartStopMarque(this ToolStripProgressBar progressBar)
        {
            if (progressBar.Style != ProgressBarStyle.Marquee)
            {
                progressBar.Style = ProgressBarStyle.Marquee;
                progressBar.MarqueeAnimationSpeed = 50;
            }
            else
            {
                progressBar.Style = ProgressBarStyle.Continuous;
                progressBar.MarqueeAnimationSpeed = 0;
            }
        }

        public static void SaveGridColumnStatus(this DataGridView dataGridView)
        {
            XElement xElement = new XElement("Columns");
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                XElement columnElement = new XElement("Column");
                columnElement.Add(new XAttribute("name", column.DataPropertyName));
                columnElement.Add(new XAttribute("visible", column.Visible));
                columnElement.Add(new XAttribute("order", column.DisplayIndex));
                xElement.Add(columnElement);
            }

            string path = Path.Combine(GlobalVariables.DocPath, $"{dataGridView.Tag}.xml");
            xElement.Save(path);
        }

        public static void LoadGridColumnStatus(this DataGridView dataGridView)
        {
            string path = Path.Combine(GlobalVariables.DocPath, $"{dataGridView.Tag}.xml");
            if (!File.Exists(path))
            {
                return;
            }
            XDocument xDocument = XDocument.Load(path);
            IEnumerable<XElement> xElements = xDocument.Descendants("Columns");

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                XElement xElement = xElements.Elements("Column").FirstOrDefault(e => e.Attribute("name").Value == column.DataPropertyName);
                if (xElement == null)
                {
                    continue;
                }

                IEnumerable<XAttribute> xAttributes = xElement.Attributes();
                column.DisplayIndex = Int32.Parse(xAttributes.FirstOrDefault(a => a.Name == "order").Value);
                column.Visible = bool.Parse(xAttributes.FirstOrDefault(a => a.Name == "visible").Value);
            }
        }

    }
}