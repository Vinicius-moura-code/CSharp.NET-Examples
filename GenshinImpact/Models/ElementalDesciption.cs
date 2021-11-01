using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinImpact.Models
{
    [Table("ElementalDesciption")]
    public class ElementalDesciption
    {
        private int id;
        private int idElement;

        private Elements element;
        private string description;

        [Key]
        public int Id { get => id; set => id = value; }

        public int IdElement { get => idElement; set => idElement = value; }

        [ForeignKey("IdElement")]
        public virtual Elements Element { get => element; set => element = value; }

        public string Description { get => description; set => description = value; }
    }
}