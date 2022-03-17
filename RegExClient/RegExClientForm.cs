#region © 2021 JoeWare.
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
        private RegExItem _regExItem = new RegExItem();
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
                // Throw away any exception
            }

            _matchesVisible = true;
        }

        // ------------------------------------------------
        // Do Not Re-arrange...

        private void HideMatches()
        {
            _regExItem.Text = tbInput.Text;
            tbInput.Text = _regExItem.Text;

            if(_matchesVisible)
            {
                tbInput.SelectionStart = tbInput.Text.Length;
                tbInput.SelectionLength = 0;
                tbInput.SelectionBackColor = Color.White;

                _matchesVisible = false;
            }
        }

        // ------------------------------------------------

        private Regex GetRegex()
        {
            Regex retVal = new Regex("~_~");

            if(!string.IsNullOrWhiteSpace(tbRegEx.Text))
            {
                var options = cbMultiline.Checked ? RegexOptions.Multiline : RegexOptions.None;
                options |= cbIgnoreCase.Checked ? RegexOptions.IgnoreCase : RegexOptions.None;

                // ------------------------------------
                // Allows us to write Windows eol RegEx
                // that still works in this app

                try
                {
                    retVal = new Regex(tbRegEx.Text.Replace(@"\r\n", @"\n"), options);
                    _regExItem.RegEx = tbRegEx.Text.Replace(@"\r\n", @"\n");
                }
                catch(Exception /*ex*/)
                {
                    retVal = new Regex("~_~");
                }
            }

            return retVal;
        }

        // ------------------------------------------------

        private void OpenRegex(string fileName, bool includeText)
        {
            _currentFile = fileName;
            
            var stream = new StreamReader(fileName);
            Text = $"{TITLE}: {Path.GetFileName(_currentFile)}";

            try
            {
                _regExItem = jsSer.Deserialize<RegExItem>(stream.ReadToEnd());

                tbReplaceResult.Text = string.Empty;

                tbRegEx.Text = _regExItem.RegEx;
                tbReplaceRegex.Text = _regExItem.RegEx;
                tbReplaceString.Text = _regExItem.ReplaceString;

                if(includeText) { tbInput.Text = _regExItem.Text; }

                ShowMatches();
            }
            finally
            {
                stream.Close();
            }
        }

        // ------------------------------------------------

        private void SaveRegEx()
        {
            var doSave = true;

            if(string.IsNullOrEmpty(_currentFile))
            {
                var saveDlg = new SaveFileDialog();
                saveDlg.Filter = "regx Files|*.regx|All Files|*.*";
                saveDlg.DefaultExt = ".regx";

                doSave = saveDlg.ShowDialog() == DialogResult.OK;

                if(doSave)
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
                    swFileStream.Write(_regExItem.ToJson());
                    swFileStream.Close();

                    Text = $"{TITLE}: {Path.GetFileName(_currentFile)}";
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

            tbReplaceRegex.Text = string.Empty;
            tbReplaceString.Text = string.Empty;
            tbReplaceResult.Text = string.Empty;

            Text = $"{TITLE}: {Path.GetFileName(_currentFile)}";

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
            Properties.Settings.Default.FormSize = Size;
            Properties.Settings.Default.ZoomFactor = tbInput.ZoomFactor;
            Properties.Settings.Default.Save();

            Application.Exit();
        }

        // ------------------------------------------------

        private void OnRegexReplace(object sender, EventArgs e)
        {
            var options = cbReplaceMultiline.Checked ? RegexOptions.Multiline : RegexOptions.None;

            try
            {
                tbReplaceResult.Text = Regex.Replace(tbReplaceInput.Text, tbReplaceRegex.Text, Regex.Unescape(tbReplaceString.Text), options);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "RegEx Exception");
            }
        }

        // ------------------------------------------------

        private void OnAbout(object sender, EventArgs e)
        {
            var dlg = new JWMarkdownDlg();
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

        private void OnInputTextChanged(object sender, EventArgs e)
        {
            _regExItem.Text = tbInput.Text;
        }

        // ------------------------------------------------

        private void OnReplacementStringChanged(object sender, EventArgs e)
        {
            tbReplaceResult.Text = string.Empty;
        }

        // ------------------------------------------------

        private void OnOpenRegex(object sender, EventArgs e)
        {
            _currentFile = string.Empty;

            var menuItem = sender as ToolStripMenuItem;

            var openDlg = new OpenFileDialog() { Filter = "regx Files|*.regx|All Files|*.*" };

            if(openDlg.ShowDialog() == DialogResult.OK)
            {
                if(menuItem != null)
                {
                    OpenRegex(openDlg.FileName, menuItem.Text.Contains("and Text"));
                }
                else
                {
                    OpenRegex(openDlg.FileName, true);
                }
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
            _regExItem.RegEx = tbRegEx.Text;
            _regExItem.Text = tbInput.Text;
            _regExItem.ReplaceString = tbReplaceString.Text;

            SaveRegEx();
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
        /// <summary>
        ///     Update the Regex regardless of which Tab we 
        ///     are on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void OnRegExValidated(object sender, EventArgs e)
        {
            _regExItem.RegEx = tbRegEx.Text;
            tbReplaceResult.Text = string.Empty;
        }

        // ------------------------------------------------
        /// <summary>
        ///     Update the Regex regardless of which Tab we 
        ///     are on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void OnReplaceRegExValidated(object sender, EventArgs e)
        {
            _regExItem.RegEx = tbReplaceRegex.Text;
            tbReplaceResult.Text = string.Empty;
        }

        // ------------------------------------------------

        private void OnTextToTestValidated(object sender, EventArgs e)
        {
            _regExItem.Text = tbReplaceInput.Text;
            tbReplaceResult.Text = string.Empty;
        }

        // ------------------------------------------------

        private void OnReplaceStringValidated(object sender, EventArgs e)
        {
            _regExItem.ReplaceString = tbReplaceString.Text;
            tbReplaceResult.Text = string.Empty;
        }

        // ------------------------------------------------

        private void OnSelected(object sender, TabControlEventArgs e)
        {
            var tab = sender as TabControl;

            switch(tab.SelectedTab.Text)
            {
                case "Regular Expression":
                    _regExItem.Text = tbReplaceInput.Text;
                    break;

                case "Regex Replace":
                    _regExItem.Text = tbInput.Text;
                    break;
            }

            if(_regExItem != null)
            {
                tbRegEx.Text = _regExItem.RegEx;

                tbInput.Text = _regExItem.Text;
                tbReplaceInput.Text = _regExItem.Text;
                
                tbReplaceRegex.Text = _regExItem.RegEx;
                tbReplaceString.Text = _regExItem.ReplaceString;

                ShowMatches();
            }
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
                    _regExItem = new RegExItem() { RegEx = tbRegEx.Text, Text = tbInput.Text, ReplaceString = tbReplaceString.Text };
                    SaveRegEx();
                    break;

                case (Keys.Control | Keys.O):
                    var openDlg = new OpenFileDialog() { Filter = "regx Files|*.regx|All Files|*.*" };

                    if(openDlg.ShowDialog() == DialogResult.OK)
                    {
                        OpenRegex(openDlg.FileName, true);
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

        // ------------------------------------------------

        private void OnToggleWordWrap(object sender, EventArgs e)
        {
            tbReplaceInput.WordWrap = cbWordWrap.Checked;
            tbReplaceResult.WordWrap = cbWordWrap.Checked;
        }

        // ------------------------------------------------

        private void OnWrapChange(object sender, EventArgs e)
        {
            tbInput.WordWrap = cbWrap.Checked;
        }
    }
}
