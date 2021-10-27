using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinImpact.Models
{
    public class Domains
    {
        private int id;
        private string name;
        private string type;
        private string description;
        private string location;
        private Nations nation;
        private List<Requirements> requirements;
        private List<Elements> recommendedElements;
        private List<Rewards> rewards;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Type { get => type; set => type = value; }
        public string Description { get => description; set => description = value; }
        public string Location { get => location; set => location = value; }
        public Nations Nation { get => nation; set => nation = value; }
        public List<Requirements> Requirements { get => requirements; set => requirements = value; }
        public List<Elements> RecommendedElements { get => recommendedElements; set => recommendedElements = value; }
        public List<Rewards> Rewards { get => rewards; set => rewards = value; }
    }
}