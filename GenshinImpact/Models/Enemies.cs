using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinImpact.Models
{
    [Table("Enemies")]
    public class Enemies
    {
        private int id;
        private string name;
        private string description;
        private string region;
        private string type;
        private string family;
        private string faction;
        private List<Elements> elements;
        private List<Artifacts> artifacts;
        private List<ElementalDesciption> elemental_description;
        private int mora_gained;

        [Key]
        public int Id { get => id; set => id = value; }

        [Required]
        public string Name { get => name; set => name = value; }

        public string Description { get => description; set => description = value; }
        public string Region { get => region; set => region = value; }
        public string Type { get => type; set => type = value; }
        public string Family { get => family; set => family = value; }
        public string Faction { get => faction; set => faction = value; }
        public List<Elements> Elements { get => elements; set => elements = value; }
        public List<Artifacts> Artifacts { get => artifacts; set => artifacts = value; }
        public List<ElementalDesciption> Elemental_description { get => elemental_description; set => elemental_description = value; }
        public int Mora_gained { get => mora_gained; set => mora_gained = value; }
    }
}