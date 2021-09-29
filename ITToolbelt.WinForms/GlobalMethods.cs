using System;
using System.Windows.Forms;
using ITToolbelt.Shared;

namespace ITToolbelt.WinForms
{
    public static class GlobalMethods
    {
        public static DialogResult DeleteConfirm(string name)
        {
            return MessageBox.Show(String.Format(Resource._010, name), Resource._009,
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
    }
}