﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Repeator
{
    public partial class MainForm : Form
    {

        private bool _stopWatch = false;
        private readonly Stack<string> _undoList = new Stack<string>();

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

                    _undoList.Push(tbText.Text);

                    var s = tbText.Text;
                    var result = string.Empty;

                    for (int i = 0; i < (int)numCount.Value; i++)
                    {
                        result += s.Replace("$i", i.ToString())
                                    .Replace("$bool", (i % 2 == 0).ToString().ToLower())
                                    .Replace("$b", (i % 2).ToString())
                                    .Replace("$g", Guid.NewGuid().ToString())
                                    .Replace("\\r\\n", Environment.NewLine)
                                    .Replace("\\n", Environment.NewLine);
                    }

                    _stopWatch = true;
                    tbText.Text = result;
                    _stopWatch = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tbText_TextChanged(object sender, EventArgs e)
        {
            if (!_stopWatch)
            {
                _undoList.Push(tbText.Text);
            }
        }

        private void tbText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Z && (e.Control) && _undoList.Count > 0)
            {
                tbText.Text = _undoList.Pop();
            }
            else if (e.KeyCode == Keys.F4)
            {
                numCount.Focus();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnRepeat.PerformClick();
            }
            else if (e.KeyCode == Keys.F6)
            {
                btnRepeatOver.PerformClick();
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.C)
            {
                numCount.Focus();
            }
        }

        private void btnInitialText_Click(object sender, EventArgs e)
        {
            if (_undoList.Count > 0)
            {

                _stopWatch = true;
                tbText.Text = _undoList.Pop();
                _stopWatch = false;

            }
        }

        private void btnRepeatOver_Click(object sender, EventArgs e)
        {
            var splitted = TextTemplateDialog.Prompt()?.ToList();

            if (splitted?.Any() ?? false)
            {
                try
                {
                    if (!string.IsNullOrEmpty(tbText.Text))
                    {

                        _undoList.Push(tbText.Text);

                        var s = tbText.Text;
                        var result = string.Empty;

                        for (int i = 0; i < splitted.Count(); i++)
                        {
                            result += s.Replace("$t", splitted[i])
                                        .Replace("$i", i.ToString())
                                        .Replace("$bool", (i % 2 == 0).ToString().ToLower())
                                        .Replace("$b", (i % 2).ToString())
                                        .Replace("$g", Guid.NewGuid().ToString())
                                        .Replace("\\r\\n", Environment.NewLine)
                                        .Replace("\\n", Environment.NewLine);
                        }

                        _stopWatch = true;
                        tbText.Text = result;
                        _stopWatch = false;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDefaultTemplate_Click(object sender, EventArgs e)
        {
            tbText.Text = $@"{{
    ""id"": $i,
    ""name"": ""Someone$i"",
    ""enabled"": $bool,
    ""bit"": $b,
    ""guid"": ""$g"",
    ""date"": new Date($i, 1, 1)
}},\r\n";
        }
    }
}
