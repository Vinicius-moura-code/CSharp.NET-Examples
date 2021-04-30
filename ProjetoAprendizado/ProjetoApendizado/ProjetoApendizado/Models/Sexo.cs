using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjetoApendizado.Models
{
    [Table("Sexos")]
    public class Sexo
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string Descricao { get; set; }
    }
}