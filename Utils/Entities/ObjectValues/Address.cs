using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Utils.Entities.ObjectValues
{
    public class Address
    {
        [RegularExpression("([0-9]+)", ErrorMessage = "O Campo CPF deve conter apenas números")]
        [StringLength(8, MinimumLength = 8, ErrorMessage = "O campo CPF deve conter 8 digitos")]
        public string ZipCode { get; set; }
        public string AddressName { get; set; }
        public string AddressDetails { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string Estate { get; set; }
    }

    public class ViaCep
    {
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string localidade { get; set; }
        public string uf { get; set; }
        public string ibge { get; set; }
        public string gia { get; set; }
        public string ddd { get; set; }
        public string siafi { get; set; }

        public static ViaCep Deserialize(string json)
        {
            return JsonConvert.DeserializeObject<ViaCep>(json);
        }
    }
}
