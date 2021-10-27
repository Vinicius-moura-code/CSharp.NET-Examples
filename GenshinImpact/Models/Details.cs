using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinImpact.Models
{
    public class Details
    {
        private int id;
        private int level;
        private int adventureExperience;
        private int companionshipExperience;
        private int mora;
        private List<Drops> drops;

        public int Id { get => id; set => id = value; }
        public int Level { get => level; set => level = value; }
        public int AdventureExperience { get => adventureExperience; set => adventureExperience = value; }
        public int CompanionshipExperience { get => companionshipExperience; set => companionshipExperience = value; }
        public int Mora { get => mora; set => mora = value; }
        public List<Drops> Drops { get => drops; set => drops = value; }
    }
}