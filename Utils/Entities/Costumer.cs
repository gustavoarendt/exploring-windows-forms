using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Utils.Entities.ObjectValues;

namespace Utils.Entities
{
    public class Costumer
    {
        [Required(ErrorMessage = "O campo Código é obrigatório")]
        [RegularExpression("([0-9]+)", ErrorMessage = "O Campo código deve conter apenas números")]
        [StringLength(6, MinimumLength = 6, ErrorMessage = "O campo código deve conter 6 digitos")]
        public string Id { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório")]
        [RegularExpression("([0-9]+)", ErrorMessage = "O Campo CPF deve conter apenas números")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "O campo CPF deve conter 11 digitos")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo Nome Completo é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo Nome Completo deve conter no máximo 50 digitos")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "O campo Nome da Mãe é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo Nome Completo deve conter no máximo 50 digitos")]
        public string MotherName { get; set; }

        public Address Address { get; set; }

        public string Job { get; set; }

        public string FullSalary { get; set; }

        [Required(ErrorMessage = "O campo Número de Telefone é obrigatório")]
        [RegularExpression("([0-9]+)", ErrorMessage = "O Campo Número de Telefone deve conter apenas números")]
        public string PhoneNumber { get; set; }

        public void Validate()
        {
            ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(this, context, results, true);

            if (!isValid)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var error in results)
                {
                    sb.AppendLine(error.ErrorMessage);
                }
                throw new ValidationException(sb.ToString());
            }
        }
    }
}
