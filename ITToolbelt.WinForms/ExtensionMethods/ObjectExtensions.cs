using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ITToolbelt.Entity.Db;
using ITToolbelt.Shared;

namespace ITToolbelt.WinForms.ExtensionMethods
{
    public static class ObjectExtensions
    {
        public static void ShowDialog(this Tuple<bool, List<string>> tuple)
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (tuple.Item1)
            {
                stringBuilder.Append(Resource._026);
            }
            else
            {
                foreach (string s in tuple.Item2)
                {
                    stringBuilder.AppendLine(s);
                }
            }

            MessageBox.Show(stringBuilder.ToString(), tuple.Item1 ? Resource._012 : Resource._014, MessageBoxButtons.OK, tuple.Item1 ? MessageBoxIcon.Information : MessageBoxIcon.Error);
        }
    }
}