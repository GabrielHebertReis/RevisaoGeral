using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public class Funcionario : Base
    {
        [Required]
        [Display(Name = "Nome do funcionário")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Função do funcionário")]
        public string Func { get; set; }

        [Required]
        [Display(Name = "Salário")]
        public decimal Salario { get; set; }

        [Required]
        [Display(Name = "Contratação do funcionário")]
        public DateTime DataContratacao { get; set; }

        [Display(Name = "Demissão do funcionário")]
        public DateTime DataDemicaocao { get; set; }

        public Base Base { get; set; }

    }
}
