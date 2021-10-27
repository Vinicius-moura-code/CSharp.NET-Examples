using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinImpact.Models
{
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
        private List<string> elemental_description;
        private int mora_gained;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string Region { get => region; set => region = value; }
        public string Type { get => type; set => type = value; }
        public string Family { get => family; set => family = value; }
        public string Faction { get => faction; set => faction = value; }
        public List<Elements> Elements { get => elements; set => elements = value; }
        public List<Artifacts> Artifacts { get => artifacts; set => artifacts = value; }
        public List<string> Elemental_description { get => elemental_description; set => elemental_description = value; }
        public int Mora_gained { get => mora_gained; set => mora_gained = value; }
    }
}