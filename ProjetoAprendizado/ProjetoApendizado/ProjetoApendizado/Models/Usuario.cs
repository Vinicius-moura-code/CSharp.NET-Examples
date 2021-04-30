using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoApendizado.Models
{
    [Table("Usuarios")]
    public class Usuario
    {
        //Nome, idade, data de nascimento, sexo, cpf.

        //[Key]Primary KEY
        //Required -> NOT NULL
        //


        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        public int Idade { get; set; }
        
        [Required]
        public DateTime DatadeNascimeto { get; set; }

        [Required]
        public int IdSexo { get; set; }
        
        [Required]
        public string Cpf { get; set; }
        
        [ForeignKey("IdSexo")]
        public virtual Sexo Sexo { get; set; }

        [Required]
        public DateTime DataInclusao { get; set; }

        [Required]
        public bool Ativo { get; set; }
    }
}