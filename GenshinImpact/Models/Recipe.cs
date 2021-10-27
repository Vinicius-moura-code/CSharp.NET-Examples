using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinImpact.Models
{
    public class Recipe
    {
        private int id;
        private string item;
        private int quantity;

        public int Id { get => id; set => id = value; }
        public string Item { get => item; set => item = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}