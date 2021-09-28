
using System.Windows.Forms;

namespace RegExClient.Help
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();

            wbHelp.Navigate(@".\Help\RegExHelp.html");
        }
    }
}
