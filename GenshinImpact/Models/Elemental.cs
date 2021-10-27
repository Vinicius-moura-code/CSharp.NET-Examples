using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinImpact.Models
{
    public class Elemental
    {
        private int id;
        private string name;
        private Elements key;
        private List<Reactions> reactions;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public Elements Key { get => key; set => key = value; }
        public List<Reactions> Reactions { get => reactions; set => reactions = value; }
    }
}