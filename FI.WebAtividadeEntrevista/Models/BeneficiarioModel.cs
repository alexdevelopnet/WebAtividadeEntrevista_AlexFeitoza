using FI.AtividadeEntrevista.DML;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAtividadeEntrevista.Models
{
    /// <summary>
    /// Classe de Modelo de Beneficiario
    /// </summary>
    public class BeneficiarioModel
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Cpf
        /// </summary>
        [RegularExpression(@"\d{3}\.\d{3}\.\d{3}-\d{2}", ErrorMessage = "Digite um e-cpf válido")]
        public string Cpf { get; set; }
        /// <summary>
        /// Cpf
        /// </summary>
        public string IdCliente { get; set; }
        public IEnumerable<Beneficiario> Beneficiarios { get; set; } = new List<Beneficiario>();

    }
}