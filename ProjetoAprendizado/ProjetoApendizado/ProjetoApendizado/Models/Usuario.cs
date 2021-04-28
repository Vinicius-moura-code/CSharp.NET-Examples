using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoApendizado.Models
{
    public class Usuario
    {
        //Nome, idade, data de nascimento, sexo, cpf.

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DatadeNascimeto { get; set; }
        public int IdSexo { get; set; }
        public string Cpf { get; set; }
        public virtual Sexo Sexo { get; set; }
        public DateTime DataInclusao { get; set; }
        public bool Ativo { get; set; }
    }
}