﻿#region © 2021 JoeWare.
//
// All rights reserved. Reproduction or transmission in whole or in part, in
// any form or by any means, electronic, mechanical, or otherwise, is prohibited
// without the prior written consent of the copyright owner.
//
#endregion

using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;

using AboutJoeWare_Lib;
using RegExClient.Help;

namespace RegExClient
{
    public partial class RegExClientForm : Form
    {
        private string _currentFile;
        private bool _matchesVisible = false;
        private const string TITLE = "Regular Expression Client";
        private readonly JavaScriptSerializer jsSer = new JavaScriptSerializer();

        public RegExClientForm(string fileName)
        {
            InitializeComponent();

            _currentFile = fileName;
            Text = TITLE;

            Size = Properties.Settings.Default.FormSize;
            tbInput.ZoomFactor = Properties.Settings.Default.ZoomFactor;
            cbIgnoreCase.Checked = Properties.Settings.Default.IgnoreCase;

            if(!string.IsNullOrWhiteSpace(fileName))
            {
                OpenRegex(fileName, true);
            }
        }

        // ------------------------------------------------

        private void ShowMatches()
        {
            var toggleColor = true;
            HideMatches();

            try
            {
                // -------------------
                // Look for groupings.

                var regex = GetRegex();

                // ----------------------------
                // Define the string to search.

                var matchCollection = regex.Matches(tbInput.Text);

                foreach(Match group in matchCollection)
                {
                    tbInput.SelectionStart = group.Index;
                    tbInput.SelectionLength = group.Length;
                    tbInput.SelectionBackColor = toggleColor ? Color.Cyan : Color.Chartreuse;
                    tbInput.SelectionProtected = true;

                    toggleColor = !toggleColor;

                    tbInput.SelectionStart = tbInput.Text.Length;
                    tbInput.SelectionLength = 0;
                    tbInput.SelectionBackColor = Color.White;
                }
            }
            catch(Exception /*ex*/)
            {
                // Throw away any exception;
            }

            _matchesVisible = true;
        }

        // ------------------------------------------------

        private void HideMatches()
        {
            if(_matchesVisible)
            {
                tbInput.Text = tbInput.Text;
                tbInput.SelectionStart = tbInput.Text.Length;
                tbInput.SelectionLength = 0;
                tbInput.SelectionBackColor = Color.White;

                _matchesVisible = false;
            }
        }

        // ------------------------------------------------

        private Regex GetRegex()
        {
            Regex retVal = null;

            if(!string.IsNullOrWhiteSpace(tbRegEx.Text))
            {
                var options = cbMultiline.Checked ? RegexOptions.Multiline : RegexOptions.None;
                options |= cbIgnoreCase.Checked ? RegexOptions.IgnoreCase : RegexOptions.None;

                // ------------------------------------
                // Allows us to write Windows eol RegEx
                // that still works in this app

                retVal = new Regex(tbRegEx.Text.Replace(@"\r\n", @"\n"), options);
            }

            return retVal;
        }

        // ------------------------------------------------

        private void OpenRegex(string fileName, bool includeText)
        {
            _currentFile = fileName;
            var stream = new StreamReader(fileName);
            Text = $"{TITLE}: {_currentFile}";

            try
            {
                var regExItem = jsSer.Deserialize<regExItem>(stream.ReadToEnd());

                tbRegEx.Text = regExItem.RegEx;

                if(includeText) { tbInput.Text = regExItem.Text; }

                ShowMatches();
            }
            finally
            {
                stream.Close();
            }
        }

        // ------------------------------------------------

        private void SaveRegEx(regExItem item)
        {
            var doSave = true;

            if(string.IsNullOrEmpty(_currentFile))
            {
                var saveDlg = new SaveFileDialog();
                saveDlg.Filter = "regx Files|*.regx|All Files|*.*";
                saveDlg.DefaultExt = ".regx";

                if(doSave = saveDlg.ShowDialog() == DialogResult.OK)
                {
                    _currentFile = saveDlg.FileName;
                }
            }

            if(doSave)
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;

                    var swFileStream = new StreamWriter(_currentFile);
                    swFileStream.Write(item.ToString());
                    swFileStream.Close();

                    Text = $"{TITLE}: {_currentFile}";
                }
                catch(Exception exp)
                {
                    MessageBox.Show(exp.Message, "Exception!");
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        // ------------------------------------------------

        private void OnNew(object sender, EventArgs e)
        {
            _currentFile = string.Empty;
            tbRegEx.Text = string.Empty;
            tbInput.Text = string.Empty;
            Text = $"{TITLE}: {_currentFile}";

            tbInput.Focus();
        }

        // ------------------------------------------------

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            ShowMatches();
        }

        // ------------------------------------------------

        private void OnExit(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        // ------------------------------------------------

        private void OnRegexReplace(object sender, EventArgs e)
        {
            tbReplaceResult.Text = Regex.Replace(tbReplaceInput.Text, tbReplaceRegex.Text, tbReplaceString.Text);
        }

        // ------------------------------------------------

        private void OnAbout(object sender, EventArgs e)
        {
            var dlg = new AboutJoeWareDlg();
            dlg.ShowDialog();
        }

        // ------------------------------------------------

        private void OnOptionsChange(object sender, EventArgs e)
        {
            ShowMatches();
        }

        // ------------------------------------------------

        private void OnHideMatches(object sender, EventArgs e)
        {
            HideMatches();
        }

        // ------------------------------------------------

        private void OnOpenRegex(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;

            var openDlg = new OpenFileDialog() { Filter = "regx Files|*.regx|All Files|*.*" };

            if(openDlg.ShowDialog() == DialogResult.OK)
            {
                OpenRegex(openDlg.FileName, menuItem.Text.Contains("and Text"));
            }
        }

        // ------------------------------------------------

        private void OnSaveAs(object sender, EventArgs e)
        {
            _currentFile = string.Empty;
            OnSaveRegEx(sender, e);
        }

        // ------------------------------------------------

        private void OnSaveRegEx(object sender, EventArgs e)
        {
            var regExItem = new regExItem() { RegEx = tbRegEx.Text, Text = tbInput.Text };
            SaveRegEx(regExItem);
        }

        // ------------------------------------------------

        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                if(_matchesVisible)
                {
                    HideMatches();
                }
                else
                {
                    ShowMatches();
                }
            }
        }

        // ------------------------------------------------

        private void OnRegExValidated(object sender, EventArgs e)
        {
            tbReplaceRegex.Text = tbRegEx.Text;
            tbReplaceInput.Text = tbInput.Text;
        }

        // ------------------------------------------------

        private void OnHelp(object sender, EventArgs e)
        {
            var dlg = new HelpForm();

            dlg.ShowDialog();
        }

        // ------------------------------------------------

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch(keyData)
            {
                case (Keys.Control | Keys.S):
                    var regExItem = new regExItem() { RegEx = tbRegEx.Text, Text = tbInput.Text };
                    SaveRegEx(regExItem);
                    break;

                case (Keys.Control | Keys.O):
                    var fileName = string.Empty;
                    var openDlg = new OpenFileDialog() { Filter = "regx Files|*.regx|All Files|*.*" };

                    if(openDlg.ShowDialog() == DialogResult.OK)
                    {
                        fileName = openDlg.FileName;
                        OpenRegex(fileName, true);
                    }

                    break;

                case (Keys.Control | Keys.Add):
                case (Keys.Control | Keys.Oemplus):
                    if(tbInput.ZoomFactor < 1.75f)
                    {
                        tbInput.ZoomFactor += .05f;
                    }
                    break;

                case (Keys.Control | Keys.Subtract):
                case (Keys.Control | Keys.OemMinus):
                    if(tbInput.ZoomFactor > .75f)
                    {
                        tbInput.ZoomFactor -= .05f;
                    }
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        // ------------------------------------------------

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.FormSize = Size;
            Properties.Settings.Default.ZoomFactor = tbInput.ZoomFactor;
            Properties.Settings.Default.IgnoreCase = cbIgnoreCase.Checked;

            Properties.Settings.Default.Save();
        }
    }
}
