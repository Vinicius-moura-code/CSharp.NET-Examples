using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinImpact.Models
{
    public class Drops
    {
        private int id;
        private string name;
        private int drop_min;
        private int drop_max;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Drop_min { get => drop_min; set => drop_min = value; }
        public int Drop_max { get => drop_max; set => drop_max = value; }
    }
}