using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using AboutJoeWare_Lib;

namespace RegExClient
{
    public partial class RegExClientForm : Form
    {
        public RegExClientForm()
        {
            InitializeComponent();
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

        private void RegExForm_Load(object sender, System.EventArgs e)
        {
            // --------------------------------------
            // Initialize the text boxes for testing.
            // The values can be changed at will and
            // tests re-run.

            //tbText.Text = "PaSSwORd";
            tbInput.Text = "01/01/2021 until 12/31/2021";
            //tbInput.Text = @"\\dcaages01\AGES\DEV\AGTracGARMImageOutput\";

            tbRegEx.Text = @"\b(0?[1-9]|1[0-2])[/\-](0?[1-3]|3[0-1])[/\-][12]\d{3}\b";
            //tbRegEx.Text = "(?=^.{8,30}$)(?=.*[A-Z])(?=.*[a-z].*[a-z].*[a-z]).*$";
            //tbRegEx.Text = "(\\\\\\\\([a-z|A-Z|0-9|-|_|\\s]{2,15}){1}(\\.[a-z|A-Z|0-9|-|_|\\s]{1,64}){0,3}){1}(\\\\[^\\\\|\\/|\\*|\\:|\\?|\"|\\<|\\>|\\|]{1,64}){1,}(\\\\){0,}";

            ShowMatches();
        }

        // ------------------------------------------------

        private void ShowMatches()
        {
            var toggleColor = true;
            ClearMatches();

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
            finally
            {
                toggleColor = true;
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

        private void ClearMatches()
        {
            tbInput.Text = tbInput.Text;
            tbInput.SelectionStart = tbInput.Text.Length;
            tbInput.SelectionLength = 0;
            tbInput.SelectionBackColor = Color.White;
        }

        // ------------------------------------------------

        private void OnAbout(object sender, EventArgs e)
        {
            var dlg = new AboutJoeWareDlg();
            dlg.ShowDialog();
        }

        // ------------------------------------------------

        private void ClearInput(object sender, EventArgs e)
        {
            tbInput.Text = string.Empty;
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
    }
}
