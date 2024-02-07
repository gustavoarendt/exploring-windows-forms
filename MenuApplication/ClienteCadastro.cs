using System.Windows.Forms;

namespace Form_ClienteCadastro
{
    public partial class ClienteCadastro: UserControl
    {
        public ClienteCadastro()
        {
            InitializeComponent();
            Grp_PersonalData.Text = "Dados Pessoais";
            Grp_Address.Text = "Endereço";
            Grp_Info.Text = "Informações";

            Lbl_District.Text = "Bairro";
            Lbl_ZipCode.Text = "CEP";
            Lbl_AddressDetails.Text = "Complemento";
            Lbl_CPF.Text = "CPF";
            Lbl_City.Text = "Cidade";
            Lbl_Estate.Text = "Estado";
            Lbl_AddressName.Text = "Logradouro";
            Lbl_FullName.Text = "Nome";
            Lbl_MotherName.Text = "Nome da Mãe";
            Lbl_Job.Text = "Profissão";
            Lbl_FullSalary.Text = "Renda Familiar";
            Lbl_PhoneNumber.Text = "Telefone";

            Cbx_Estate.Items.AddRange(new string[]
            {
                "Rio De Janeiro",
                "Rio Grande do Sul",
                "São Paulo",
            });
        }
    }
}
