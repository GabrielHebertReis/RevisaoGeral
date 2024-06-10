using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public class Empresa : Base
    {
        [Required]
        [Display(Name = "Nome da empresa")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "CNPJ")]
        public long CNPJ { get; set; }

        [Required]
        [Display(Name = "Presidente")]
        public string CEO { get; set; }

        [Required]
        [Display(Name = "Quadro de funcionários")]
        public Funcionario Funcionario { get; set; }

        [Required]
        [Display(Name = "Abertura da empresa")]
        public DateTime Abertura { get; set; }

        [Display(Name = "Fechamento da empresa")]
        public DateTime Extincao { get; set; }


    }
}
