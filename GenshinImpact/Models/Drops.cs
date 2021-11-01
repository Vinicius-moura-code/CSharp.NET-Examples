using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinImpact.Models
{
    [Table("Drops")]
    public class Drops
    {
        private int id;
        private string name;
        private int drop_min;
        private int drop_max;

        [Key]
        public int Id { get => id; set => id = value; }

        [Required]
        public string Name { get => name; set => name = value; }

        public int Drop_min { get => drop_min; set => drop_min = value; }
        public int Drop_max { get => drop_max; set => drop_max = value; }
    }
}