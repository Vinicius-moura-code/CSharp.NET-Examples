using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinImpact.Models
{
    public class ConsumablesFood
    {
        private int id;
        private string name;
        private int rarity;
        private string type;
        private string effect;
        private bool hasRecipe;
        private string description;
        private int proficiency;
        private List<Recipe> recipe;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Rarity { get => rarity; set => rarity = value; }
        public string Type { get => type; set => type = value; }
        public string Effect { get => effect; set => effect = value; }
        public bool HasRecipe { get => hasRecipe; set => hasRecipe = value; }
        public string Description { get => description; set => description = value; }
        public int Proficiency { get => proficiency; set => proficiency = value; }
        public List<Recipe> Recipe { get => recipe; set => recipe = value; }
    }
}