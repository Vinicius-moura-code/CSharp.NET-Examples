using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinImpact.Models
{
    [Table("SkillTalents")]
    public class SkillTalents
    {
        private int id;
        private string name;
        private string unlock;
        private string description;
        private string type;

        [Key]
        public int Id { get => id; set => id = value; }

        [Required]
        public string Name { get => name; set => name = value; }

        public string Unlock { get => unlock; set => unlock = value; }
        public string Description { get => description; set => description = value; }
        public string Type { get => type; set => type = value; }
    }
}