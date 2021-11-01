using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinImpact.Models
{
    [Table("Elements")]
    public class Elements
    {
        private int id;
        private string type;

        [Key]
        public int Id { get => id; set => id = value; }

        [Required]
        public string Type { get => type; set => type = value; }
    }
}