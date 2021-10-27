using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinImpact.Models
{
    public class Nations
    {
        private int id;
        private string name;
        private string element;
        private string archon;
        private string controllingEntity;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Element { get => element; set => element = value; }
        public string Archon { get => archon; set => archon = value; }
        public string ControllingEntity { get => controllingEntity; set => controllingEntity = value; }
    }
}