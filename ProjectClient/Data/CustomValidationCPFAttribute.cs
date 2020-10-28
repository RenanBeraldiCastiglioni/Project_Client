using ProjectClient.Bussiness;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Web.Mvc;

namespace ProjectClient.Data
{
    public class CustomValidationCPFAttribute : ValidationAttribute, IClientValidatable
    {
        /// <summary>
        /// Construtor
        /// </summary>
        public CustomValidationCPFAttribute() { }

        /// <summary>
        /// Validação server
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Models.CPF IsValid(string _cpf)
        {
            Models.CPF cpf = new Models.CPF();
            StringBuilder mensagem = new StringBuilder();

            if (string.IsNullOrEmpty(_cpf))
            {
                cpf.Valido = false;
                mensagem.AppendLine("O CPF não foi informado");
            }

            if (!CPF.ValidaCPF(_cpf))
            {
                cpf.Valido = false;
                mensagem.AppendLine("O CPF informado é inválido");
            }

            cpf.Mensagem = mensagem.ToString();
            return cpf;
        }

        //public override bool IsValid(object value)
        //{
        //    if (value == null || string.IsNullOrEmpty(value.ToString()))
        //        return true;

        //    bool valido = CPF.ValidaCPF(value.ToString());
        //    return valido;
        //}

        /// <summary>
        /// Validação client
        /// </summary>
        /// <param name="metadata"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public IEnumerable<ModelClientValidationRule> GetClientValidationRules(
            ModelMetadata metadata, ControllerContext context)
        {
            yield return new ModelClientValidationRule
            {
                ErrorMessage = this.FormatErrorMessage(null),
                ValidationType = "customvalidationcpf"
            };
        }
    }
}
