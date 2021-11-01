using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinImpact.Models
{
    [Table("Weapons")]
    public class Weapons
    {
        private int id;
        private String name;
        private String type;
        private int rarity;
        private int baseAttack;
        private String subStat;
        private String passiveName;
        private String subSpassiveDesctat;
        private String location;

        [Key]
        public int Id { get => id; set => id = value; }

        [Required]
        public string Name { get => name; set => name = value; }

        public string Type { get => type; set => type = value; }
        public int Rarity { get => rarity; set => rarity = value; }
        public int BaseAttack { get => baseAttack; set => baseAttack = value; }
        public string SubStat { get => subStat; set => subStat = value; }
        public string PassiveName { get => passiveName; set => passiveName = value; }
        public string SubSpassiveDesctat { get => subSpassiveDesctat; set => subSpassiveDesctat = value; }
        public string Location { get => location; set => location = value; }
    }
}