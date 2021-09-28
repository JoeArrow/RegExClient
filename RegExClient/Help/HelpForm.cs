
using System.Windows.Forms;

namespace RegExClient.Help
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();

            wbHelp.Navigate(@"C:\Usage\_Source\CSharp\JoeWare\RegExClient\RegExClient\Help\RegExHelp.html");
        }
    }
}
