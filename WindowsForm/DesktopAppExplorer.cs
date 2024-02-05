using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Frm_DesktopAppExplorer : Form
    {
        public Frm_DesktopAppExplorer()
        {
            InitializeComponent();
        }

        private void Btn_ExitButton_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
