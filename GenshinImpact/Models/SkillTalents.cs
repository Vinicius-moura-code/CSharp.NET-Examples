using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinImpact.Models
{
    public class SkillTalents
    {
        private int id;
        private string name;
        private string unlock;
        private string description;
        private string type;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Unlock { get => unlock; set => unlock = value; }
        public string Description { get => description; set => description = value; }
        public string Type { get => type; set => type = value; }
    }
}