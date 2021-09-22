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
        }

        // ------------------------------------------------

        private void RegExForm_Load(object sender, EventArgs e)
        {
            // --------------------------------------
            // Initialize the text boxes for testing.
            // The values can be changed at will and
            // tests re-run.

            #if DEBUG
                //tbText.Text = "PaSSwORd";
                tbInput.Text = "01/01/2021 until 12/31/2021";
                //tbInput.Text = @"\\dcaages01\AGES\DEV\AGTracGARMImageOutput\";

                tbRegEx.Text = @"\b(0?[1-9]|1[0-2])[/\-](0?[1-3]|3[0-1])[/\-][12]\d{3}\b";
                //tbRegEx.Text = "(?=^.{8,30}$)(?=.*[A-Z])(?=.*[a-z].*[a-z].*[a-z]).*$";
                //tbRegEx.Text = @"(\\\\([a-z|A-Z|0-9|-|_|\s]{2,15}){1}(\.[a-z|A-Z|0-9|-|_|\s]{1,64}){0,3}){1}(\\[^\\|\/|\*|\:|\?||\<|\>|\|]{1,64}){1,}(\\){0,}";

                ShowMatches();
            #endif
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
                    tbInput.SelectionBackColor = toggleColor ? Color.Cyan : Color.Aquamarine;
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
            var retVal = new Regex(".*");
            var options = cbMultiLine.Checked ? RegexOptions.Multiline : RegexOptions.None;
            options |= cbIgnoreCase.Checked ? RegexOptions.IgnoreCase : RegexOptions.None;

            retVal = cbIgnoreCase.Checked ? new Regex(tbRegEx.Text, options) : new Regex(tbRegEx.Text);

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

        private void OnMatch(object sender, EventArgs e)
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
                var stream = new StreamReader(openDlg.FileName);
                var regExItem = jsSer.Deserialize<regExItem>(stream.ReadToEnd());

                tbInput.Text = regExItem.Text;

                // ------------------------------------------------
                // Only load the text if the menu item was selected

                if(menuItem.Text.Contains("and Text"))
                {
                    tbRegEx.Text = regExItem.RegEx;
                }

                ShowMatches();
            }
        }

        // ------------------------------------------------

        private void OnSaveRegEx(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;

            if(menuItem != null)
            {
                var regExItem = new regExItem() { RegEx = tbRegEx.Text, Text = menuItem.Text.Contains("and Text") ? tbInput.Text : string.Empty };

                var saveDlg = new SaveFileDialog();
                saveDlg.Filter = "regx Files|*.regx|All Files|*.*";
                saveDlg.DefaultExt = ".regx";

                if(saveDlg.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    try
                    {
                        var swFileStream = new StreamWriter(saveDlg.FileName);
                        swFileStream.Write(regExItem.ToString());
                        swFileStream.Close();
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
        }

        // ------------------------------------------------

        private void ClearInput(object sender, EventArgs e)
        {
            tbInput.Text = string.Empty;
        }
    }
}
