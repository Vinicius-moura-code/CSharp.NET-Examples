using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinImpact.Models
{
    public class Requirements
    {
        private int id;
        private int level;
        private int adventureRank;
        private int recommendedLevel;
        private string leyLineDisorder;

        public int Id { get => id; set => id = value; }
        public int Level { get => level; set => level = value; }
        public int AdventureRank { get => adventureRank; set => adventureRank = value; }
        public int RecommendedLevel { get => recommendedLevel; set => recommendedLevel = value; }
        public string LeyLineDisorder { get => leyLineDisorder; set => leyLineDisorder = value; }
    }
}