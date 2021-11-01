using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinImpact.Models
{
    [Table("ConsumablesFood")]
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

        [Key]
        public int Id { get => id; set => id = value; }

        [Required]
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