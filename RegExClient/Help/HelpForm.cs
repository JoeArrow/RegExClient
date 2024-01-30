using System;
using System.IO;
using System.Windows.Forms;

namespace Reggie.Help
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();

            var curDir = Directory.GetCurrentDirectory();
            wbHelp.Url = new Uri($@"file:///{curDir}\Help\RegExHelp.html");
        }
    }
}
