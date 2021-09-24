using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;

using AboutJoeWare_Lib;
using System.IO;

namespace RegExClient
{
    public partial class RegExClientForm : Form
    {
        private bool _matchesVisible = false;
        private readonly JavaScriptSerializer jsSer = new JavaScriptSerializer();

        public RegExClientForm()
        {
            InitializeComponent();
            lblFileName.Text = string.Empty;
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

        private void ClearInput(object sender, EventArgs e)
        {
            tbInput.Text = string.Empty;
        }

        // ------------------------------------------------

        private Regex GetRegex()
        {
            var retVal = new Regex(".*");
            var options = RegexOptions.Multiline;
            options |= cbIgnoreCase.Checked ? RegexOptions.IgnoreCase : RegexOptions.None;

            // ------------------------------------
            // Allows us to write Windows eol RegEx
            // that still works in this app

            retVal = new Regex(tbRegEx.Text.Replace(@"\r\n", @"\n"), options);

            return retVal;
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
            OpenRegex(menuItem.Text.Contains("and Text"));
        }

        // ------------------------------------------------

        private void OnSaveRegEx(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;

            if(menuItem != null)
            {
                var regExItem = new regExItem() { RegEx = tbRegEx.Text, Text = menuItem.Text.Contains("and Text") ? tbInput.Text : string.Empty };
                SaveRegEx(regExItem);
            }
        }

        // ------------------------------------------------
        
        private void SaveRegEx(regExItem item)
        {
            var saveDlg = new SaveFileDialog();
            saveDlg.Filter = "regx Files|*.regx|All Files|*.*";
            saveDlg.DefaultExt = ".regx";

            if(saveDlg.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;

                try
                {
                    var swFileStream = new StreamWriter(saveDlg.FileName);
                    swFileStream.Write(item.ToString());
                    swFileStream.Close();

                    lblFileName.Text = saveDlg.FileName;
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

        private void OpenRegex(bool includeText)
        {
            var openDlg = new OpenFileDialog() { Filter = "regx Files|*.regx|All Files|*.*" };

            if(openDlg.ShowDialog() == DialogResult.OK)
            {
                var stream = new StreamReader(openDlg.FileName);
                lblFileName.Text = openDlg.FileName;

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

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == (Keys.Control | Keys.S))
            {
                var regExItem = new regExItem() { RegEx = tbRegEx.Text, Text = tbInput.Text };
                SaveRegEx(regExItem);
            }
            else if(keyData == (Keys.Control | Keys.O))
            {
                OpenRegex(true);
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
