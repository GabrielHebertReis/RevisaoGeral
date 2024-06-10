using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public class Endereco : Base
    {
        [DisplayFormat(DataFormatString = "mm/dd/yyyy")]

        [Required]
        [Display(Name = "CEP")]
        public int CEP { get; set; }
        [Display(Name = "Número")]
        public string Numero { get; set; }
        [Required]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }
        [Required]
        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }
        [Required]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }
        [Required]
        [Display(Name = "Estado")]
        public string Estado { get; set; }
        [Required]
        [Display(Name = "Pais")]
        public string Pais { get; set; }
    }
}
