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
    public partial class MainForm : Form
    {

        Stack<string> undoList = new Stack<string>();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(tbText.Text))
                {

                    undoList.Push(tbText.Text);

                    var s = tbText.Text;
                    var result = string.Empty;

                    for (int i = 0; i < (int)numCount.Value; i++)
                    {
                        result += s.Replace("$i", i.ToString())
                                       .Replace("$b", (i % 2).ToString())
                                       .Replace("\\r\\n", Environment.NewLine)
                                       .Replace("\\n", Environment.NewLine);
                    }

                    tbText.Text = result;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbText_TextChanged(object sender, EventArgs e)
        {
            undoList.Push(tbText.Text);
        }

        private void tbText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z && (e.Control))
            {
                tbText.Text = undoList.Pop();
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.C)
            {
                numCount.Focus();
            }
        }
    }
}
