using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Funcionario : Base
    {
        public string Nome { get; set; }
        public string Func { get; set; }
        public int Salario { get; set; }
        public Base Base { get; set; }

    }
}
