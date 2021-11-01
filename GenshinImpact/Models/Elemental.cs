using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinImpact.Models
{
    [Table("Elemental")]
    public class Elemental
    {
        private int id;
        private string name;
        private int idKey;
        private Elements key;
        private List<Reactions> reactions;

        [Key]
        public int Id { get => id; set => id = value; }

        [Required]
        public string Name { get => name; set => name = value; }

        public int IdKey { get => idKey; set => idKey = value; }

        [ForeignKey("IdKey")]
        public virtual Elements Key { get => key; set => key = value; }

        public List<Reactions> Reactions { get => reactions; set => reactions = value; }
    }
}