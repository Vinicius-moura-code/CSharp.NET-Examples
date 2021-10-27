using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinImpact.Models
{
    public class Characters
    {
        private int id;
        private String name; //+
        private String vision;//*
        private String weapon;//*
        private Nations nation;//*
        private String affiliation;//*
        private int rarity;
        private String constellation;
        private String birthday;
        private String description;
        private List<SkillTalents> skillTalents;
        private List<PassiveTalents> passiveTalents;
        private List<Constellations> constellations;
        private string vision_key;

        [Key]
        public int Id { get => id; set => id = value; }

        [Required]
        public string Name { get => name; set => name = value; }

        public string Vision { get => vision; set => vision = value; }
        public string Weapon { get => weapon; set => weapon = value; }

        public Nations Nation { get => nation; set => nation = value; }
        public string Affiliation { get => affiliation; set => affiliation = value; }
        public int Rarity { get => rarity; set => rarity = value; }
        public string Constellation { get => constellation; set => constellation = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public string Description { get => description; set => description = value; }
        public List<SkillTalents> SkillTalents { get => skillTalents; set => skillTalents = value; }
        public List<PassiveTalents> PassiveTalents { get => passiveTalents; set => passiveTalents = value; }
        public List<Constellations> Constellations { get => constellations; set => constellations = value; }
        public string Vision_key { get => vision_key; set => vision_key = value; }
    }
}