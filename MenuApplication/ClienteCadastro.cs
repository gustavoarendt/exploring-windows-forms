using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_ClienteCadastro
{
    public partial class ClienteCadastro: UserControl
    {
        public ClienteCadastro()
        {
            InitializeComponent();

            Lbl_District.Text = "Bairro";
            Lbl_ZipCode.Text = "CEP";
            Lbl_AddressDetails.Text = "Complemento";
            Lbl_CPF.Text = "CPF";
            Lbl_Estate.Text = "Estado";
            Lbl_AddressName.Text = "Logradouro";
            Lbl_FullName.Text = "Nome";
            Lbl_MotherName.Text = "Nome da Mãe";
            Lbl_Job.Text = "Profissão";
            Lbl_FullSalary.Text = "Renda Familiar";
            Lbl_PhoneNumber.Text = "Telefone";
        }
    }
}
