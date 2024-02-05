using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Frm_PasswordValidator : Form
    {
        public Frm_PasswordValidator()
        {
            InitializeComponent();
        }

        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            Txt_Password.Text = string.Empty;
            Lbl_Level.Text = string.Empty;
            
        }

        private void Btn_TooglePassword_Click(object sender, EventArgs e)
        {
            if (Txt_Password.PasswordChar != '\0')
            {
                Txt_Password.PasswordChar = '\0';
                Btn_TooglePassword.Text = "Esconder Senha";
            }
            else
            {
                Txt_Password.PasswordChar = '*';
                Btn_TooglePassword.Text = "Mostrar Senha";
            }
        }

        private void Txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            var passwordChecker = new PasswordChecker();
            var result = passwordChecker.GetPasswordLevel(Txt_Password.Text);
            Lbl_Level.Text = result;

            if (result == PasswordLevel.WORST.GetDescription()
                || result == PasswordLevel.WEAK.GetDescription())
            {
                Lbl_Level.ForeColor = Color.Red;
            }
            if (result == PasswordLevel.ACCEPTABLE.GetDescription())
            {
                Lbl_Level.ForeColor = Color.Cyan;
            }
            if (result == PasswordLevel.STRONG.GetDescription() 
                || result == PasswordLevel.SECURE.GetDescription())
            {
                Lbl_Level.ForeColor = Color.Green;
            }
        }
    }
}
