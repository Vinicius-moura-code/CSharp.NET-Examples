using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinImpact.Models
{
    [Table("ConsumablesPotions")]
    public class ConsumablesPotions
    {
        private int id;
        private string name;
        private string effect;
        private int rarity;
        private List<Recipe> crafting;

        [Key]
        public int Id { get => id; set => id = value; }

        [Required]
        public string Name { get => name; set => name = value; }

        public int Rarity { get => rarity; set => rarity = value; }
        public string Effect { get => effect; set => effect = value; }
        public List<Recipe> Crafting { get => crafting; set => crafting = value; }
    }
}