using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinImpact.Models
{
    [Table("Domains")]
    public class Domains
    {
        private int id;
        private string name;
        private string type;
        private string description;
        private string location;
        private int idNation;
        private Nations nation;
        private List<Requirements> requirements;
        private List<Elements> recommendedElements;
        private List<Rewards> rewards;

        [Key]
        public int Id { get => id; set => id = value; }

        [Required]
        public string Name { get => name; set => name = value; }

        public string Type { get => type; set => type = value; }
        public string Description { get => description; set => description = value; }
        public string Location { get => location; set => location = value; }

        public int IdNation { get => idNation; set => idNation = value; }

        [ForeignKey("IdNation")]
        public virtual Nations Nation { get => nation; set => nation = value; }

        public List<Requirements> Requirements { get => requirements; set => requirements = value; }
        public List<Elements> RecommendedElements { get => recommendedElements; set => recommendedElements = value; }
        public List<Rewards> Rewards { get => rewards; set => rewards = value; }
    }
}