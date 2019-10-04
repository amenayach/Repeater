using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repeator
{
    public partial class TextTemplateDialog : Form
    {
        public static string LastValue = "aaa, bbb, ccc";

        public TextTemplateDialog()
        {
            InitializeComponent();
            tbCommaSeperatedList.Text = LastValue;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        public static IEnumerable<string> Prompt()
        {
            using (var form = new TextTemplateDialog())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LastValue = form.tbCommaSeperatedList.Text;

                    return form.tbCommaSeperatedList.Text.Split(',').Select(m => m.Trim());
                }

                return new List<string>();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TextTemplateDialog_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnCancel_Click(btnCancel, null);
            }
        }

        private void tbCommaSeperatedList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                btnOk_Click(btnOk, null);
            }
        }
    }
}
