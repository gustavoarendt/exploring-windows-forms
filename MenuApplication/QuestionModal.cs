using System.Windows.Forms;

namespace MenuApplication
{
    public partial class Form_Question : Form
    {
        public Form_Question(string question)
        {
            InitializeComponent();
            Lbl_Question.Text = question;
        }

        private void Btn_Confirm_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
