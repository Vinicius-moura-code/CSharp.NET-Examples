using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinImpact.Models
{
    public class Reactions
    {
        private int id;
        private string name;
        private Elements elements;
        private string description;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public Elements Elements { get => elements; set => elements = value; }
        public string Description { get => description; set => description = value; }
    }
}