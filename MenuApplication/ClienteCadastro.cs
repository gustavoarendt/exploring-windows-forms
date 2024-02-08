using MenuApplication;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using Utils;
using Utils.Entities;
using Utils.Entities.ObjectValues;
using Utils.JsonDatabase;

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

        private void Menu_FerramentaNew_Click(object sender, EventArgs e)
        {
            try
            {
                var costumer = ReadForm();
                costumer.Validate();
                CostumerDb db = new CostumerDb("C:\\temp");
                costumer.Save(db);
                MessageBox.Show($"Cliente {costumer.Id} salvo com sucesso", "Cadastro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show($"Erro de validação: {ex.Message}", "Cadastro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Cadastro de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Txt_ZipCode_Leave(object sender, EventArgs e)
        {
            var cep = Txt_ZipCode.Text;
            if (cep.Length == 8)
            {
                if (cep.All(char.IsNumber))
                {
                    var responseViaCep = await Network.GetAddressJsonViaCep(cep);
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

        private void Menu_FerramentaClear_Click(object sender, EventArgs e)
        {
            Txt_Code.Text = "";
            Txt_District.Text = "";
            Txt_ZipCode.Text = "";
            Txt_AddressDetails.Text = "";
            Txt_CPF.Text = "";
            Txt_City.Text = "";
            Txt_Estate.Text = "";
            Txt_AddressName.Text = "";
            Txt_FullName.Text = "";
            Txt_MotherName.Text = "";
            Txt_Job.Text = "";
            Txt_FullSalary.Text = "";
            Txt_PhoneNumber.Text = "";
        }

        private void Menu_FerramentaDelete_Click(object sender, EventArgs e)
        {
            CheckIfCodeExists();

            var code = Txt_Code.Text.Trim();
            var db = new CostumerDb("C:\\temp");
            var costumerJson = db.FindOne(code);
            if (db.IsSuccess)
            {
                var costumer = Costumer.Deserialize(costumerJson);
                WriteForm(costumer);

                var confirm = new Form_Question("Tem certeza que deseja excluir?");
                if (confirm.ShowDialog() == DialogResult.Yes)
                {
                    db.Delete(code);
                    if (db.IsSuccess)
                    {
                        MessageBox.Show("OK", "Exclusão de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Menu_FerramentaClear_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show($"ERRO: {db.Message}", "Exclusão de cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Menu_FerramentaOpen_Click(object sender, EventArgs e)
        {
            CheckIfCodeExists();
            var code = Txt_Code.Text.Trim();
            var db = new CostumerDb("C:\\temp");
            var costumerJson = db.FindOne(code);
            if (db.IsSuccess)
            {
                var costumer = Costumer.Deserialize(costumerJson);
                WriteForm(costumer);
            }
            else
            {
                MessageBox.Show($"ERRO: {db.Message}", "Buscar cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Menu_FerramentaSave_Click(object sender, EventArgs e)
        {
            var consumer = ReadForm();
            consumer.Validate();
            CostumerDb db = new CostumerDb("C:\\temp");
            if (db.IsSuccess)
            {
                consumer.Update(db);
                MessageBox.Show("OK", "Atualização de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"ERRO: {db.Message}", "Atualização de cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckIfCodeExists()
        {
            if (string.IsNullOrWhiteSpace(Txt_Code.Text) && Txt_Code.Text.Length != 6)
            {
                MessageBox.Show("Erro: Código válido ou não informado");
            }
        }

        private void WriteForm(Costumer costumer)
        {
            Txt_Code.Text = costumer.Id;
            Txt_District.Text = costumer.Address.District;
            Txt_ZipCode.Text = costumer.Address.ZipCode;
            Txt_AddressDetails.Text = costumer.Address.AddressDetails;
            Txt_CPF.Text = costumer.CPF;
            Txt_City.Text = costumer.Address.City;
            Txt_Estate.Text = costumer.Address.Estate;
            Txt_AddressName.Text = costumer.Address.AddressName;
            Txt_FullName.Text = costumer.FullName;
            Txt_MotherName.Text = costumer.MotherName;
            Txt_Job.Text = costumer.Job;
            Txt_FullSalary.Text = costumer.FullSalary;
            Txt_PhoneNumber.Text = costumer.PhoneNumber;
        }

        private Costumer ReadForm()
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

            return new Costumer()
            {
                Id = Txt_Code.Text,
                CPF = Txt_CPF.Text,
                FullName = Txt_FullName.Text,
                MotherName = Txt_MotherName.Text,
                PhoneNumber = Txt_PhoneNumber.Text,
                FullSalary = Txt_FullSalary.Text,
                Job = Txt_Job.Text,
                Address = address,
            };
        }
    }
}
