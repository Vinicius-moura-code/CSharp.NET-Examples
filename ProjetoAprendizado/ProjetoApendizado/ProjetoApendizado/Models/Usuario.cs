using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoApendizado.Models
{
    public class Usuario
    {
        //Nome, idade, data de nascimento, sexo, cpf.

        public string Nome { get; set;}

        public int Idade { get; set; }

        public DateTime DatadeNascimeto { get; set; }

        public string Sexo { get; set; }

        public int Cpf { get; set;  }

    }
} 