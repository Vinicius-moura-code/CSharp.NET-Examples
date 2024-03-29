﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinImpact.Models
{
    [Table("Nations")]
    public class Nations
    {
        private int id;
        private string name;
        private int idElement;
        private Elements element;
        private string archon;
        private string controllingEntity;

        [Key]
        public int Id { get => id; set => id = value; }

        [Required]
        public string Name { get => name; set => name = value; }

        public int IdElement { get => idElement; set => idElement = value; }

        [ForeignKey("IdElement")]
        public virtual Elements Element { get => element; set => element = value; }

        public string Archon { get => archon; set => archon = value; }
        public string ControllingEntity { get => controllingEntity; set => controllingEntity = value; }
    }
}