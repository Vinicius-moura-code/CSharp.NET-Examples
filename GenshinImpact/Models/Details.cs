using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinImpact.Models
{
    [Table("Details")]
    public class Details
    {
        private int id;
        private int level;
        private int adventureExperience;
        private int companionshipExperience;
        private int mora;
        private List<Drops> drops;

        [Key]
        public int Id { get => id; set => id = value; }

        public int Level { get => level; set => level = value; }
        public int AdventureExperience { get => adventureExperience; set => adventureExperience = value; }
        public int CompanionshipExperience { get => companionshipExperience; set => companionshipExperience = value; }
        public int Mora { get => mora; set => mora = value; }
        public List<Drops> Drops { get => drops; set => drops = value; }
    }
}