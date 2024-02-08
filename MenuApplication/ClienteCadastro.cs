using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using Utils;
using Utils.Entities;
using Utils.Entities.ObjectValues;

namespace Form_ClienteCadastro
{
    public partial class ClienteCadastro : UserControl
    {
        public ClienteCadastro()
        {
            InitializeComponent();
            Grp_PersonalData.Text = "Dados Pessoais";
            Grp_Address.Text = "Endereço";
            Grp_Info.Text = "Informações";

            Lbl_Code.Text = "Código";
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
        }

        private void Menu_FerramentaSave_Click(object sender, System.EventArgs e)
        {
            try
            {
                var address = new Address
                {
                    ZipCode = Txt_ZipCode.Text,
                    AddressName = Txt_AddressName.Text,
                    AddressDetails = Txt_AddressDetails.Text,
                    District = Txt_District.Text,
                    Estate = Txt_Estate.Text,
                    City = Txt_City.Text,
                };

                var cliente = new Costumer()
                {
                    Id = Txt_Code.Text,
                    CPF = Txt_CPF.Text,
                    FullName = Txt_FullSalary.Text,
                    MotherName = Txt_MotherName.Text,
                    PhoneNumber = Txt_PhoneNumber.Text,
                    FullSalary = Txt_FullSalary.Text,
                    Job = Txt_Job.Text,
                    Address = address,
                };

                cliente.Validate();

                MessageBox.Show("Cliente salvo com sucesso", "Cadastro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Cadastro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Txt_ZipCode_Leave(object sender, EventArgs e)
        {
            var cep = Txt_ZipCode.Text;
            if (cep.Length == 8)
            {
                if (cep.All(char.IsNumber))
                {
                    var responseViaCep = Network.GetAddressJsonViaCep(cep);
                    var viaCep = ViaCep.Deserialize(responseViaCep);
                    if (responseViaCep != null)
                    {
                        Txt_AddressName.Text = viaCep.logradouro;
                        Txt_City.Text = viaCep.localidade;
                        Txt_District.Text = viaCep.bairro;
                        Txt_Estate.Text = viaCep.uf;
                    }
                }
            }
        }
    }
}
