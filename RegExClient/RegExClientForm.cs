using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegExClient
{
    public partial class RegExClientForm : Form
    {
        public RegExClientForm()
        {
            InitializeComponent();
        }

        // ------------------------------------------------

        private void ShowMatches()
        {
            var toggleColor = true;

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
                    tbInput.SelectionBackColor = toggleColor ? Color.Cyan : Color.Yellow;
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

            tbRegEx.Text = @"[0-2]?\d[/\-][0-3]?\d[/\-][12]\d{3}";
            //tbRegEx.Text = "(?=^.{8,30}$)(?=.*[A-Z])(?=.*[a-z].*[a-z].*[a-z]).*$";
            //tbRegEx.Text = "(\\\\\\\\([a-z|A-Z|0-9|-|_|\\s]{2,15}){1}(\\.[a-z|A-Z|0-9|-|_|\\s]{1,64}){0,3}){1}(\\\\[^\\\\|\\/|\\*|\\:|\\?|\"|\\<|\\>|\\|]{1,64}){1,}(\\\\){0,}";

            ShowMatches();
        }

        // ------------------------------------------------

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            ShowMatches();
        }

        // ------------------------------------------------

        private Regex GetRegex()
        {
            var retVal = null as Regex;

            if(rbIgnoreCase.Checked)
            {
                retVal = new Regex(tbRegEx.Text, RegexOptions.IgnoreCase);
            }
            else
            {
                retVal = new Regex(tbRegEx.Text);
            }

            return retVal;
        }
    }
}
