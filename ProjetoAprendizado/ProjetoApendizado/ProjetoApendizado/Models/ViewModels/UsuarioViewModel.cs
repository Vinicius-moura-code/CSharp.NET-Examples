using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoApendizado.Models.ViewModels
{
    public class UsuarioViewModel
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DatadeNascimeto { get; set; }
        public int IdSexo { get; set; }
        public string Cpf { get; set; }

        public int Id { get; set; }

    }
}