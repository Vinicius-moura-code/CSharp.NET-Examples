using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinImpact.Models
{
    public class Materials
    {
        private int id;
        private Elements type;
        private string name;
        private string source;

        public int Id { get => id; set => id = value; }
        public Elements Type { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }
        public string Source { get => source; set => source = value; }
    }
}