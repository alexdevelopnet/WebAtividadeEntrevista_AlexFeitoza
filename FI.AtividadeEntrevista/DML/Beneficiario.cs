﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FI.AtividadeEntrevista.DML
{
    /// <summary>
    /// Classe de cliente que representa o registo na tabela Cliente do Banco de Dados
    /// </summary>
    public class Beneficiario
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
        public string Cpf { get; set; }
        /// <summary>
        /// Cpf
        /// </summary>
        public string IdCliente { get; set; }
    }   
    
}
