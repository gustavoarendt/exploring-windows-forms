using System;
using System.Windows.Forms;

namespace MenuApplication
{
    public partial class Form_Authentication : Form
    {
        public Form_Authentication()
        {
            InitializeComponent();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (Txt_Password.Text == "123123")
            {
                MessageBox.Show($"Bem vindo, {Txt_Login.Text}!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            } else
            {
                MessageBox.Show("Credenciais inválidas", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult = DialogResult.Abort;
            }
        }

        private void Txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Login_Click(sender, e);
            }
        }
    }
}
