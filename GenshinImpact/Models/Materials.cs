using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinImpact.Models
{
    [Table("Materials")]
    public class Materials
    {
        private int id;
        private int idType;
        private Elements type;
        private string name;
        private string source;

        [Key]
        public int Id { get => id; set => id = value; }

        [Required]
        public int IdType { get => idType; set => idType = value; }

        [ForeignKey("IdType")]
        public virtual Elements Type { get => type; set => type = value; }

        public string Name { get => name; set => name = value; }
        public string Source { get => source; set => source = value; }
    }
}