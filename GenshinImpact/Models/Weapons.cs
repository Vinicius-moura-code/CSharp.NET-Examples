using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinImpact.Models
{
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

        public int Id { get => id; set => id = value; }
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