using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinImpact.Models
{
    [Table("Recipe")]
    public class Recipe
    {
        private int id;
        private string item;
        private int quantity;

        [Key]
        public int Id { get => id; set => id = value; }

        public string Item { get => item; set => item = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}