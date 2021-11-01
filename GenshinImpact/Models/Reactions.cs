using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinImpact.Models
{
    [Table("Reactions")]
    public class Reactions
    {
        private int id;
        private string name;
        private Elements elements;
        private string description;
        private int idElements;

        [Key]
        public int Id { get => id; set => id = value; }

        public string Name { get => name; set => name = value; }
        public int IdElements { get => idElements; set => idElements = value; }

        [ForeignKey("IdElements")]
        public virtual Elements Elements { get => elements; set => elements = value; }

        public string Description { get => description; set => description = value; }
    }
}