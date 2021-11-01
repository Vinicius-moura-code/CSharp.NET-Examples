using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinImpact.Models
{
    [Table("Artifacts")]
    public class Artifacts
    {
        private int id;
        private String name;
        private int max_rarity;
        private String two_piece_bonus;
        private String four_piece__bonus;

        [Key]
        public int Id { get => id; set => id = value; }

        [Required]
        [MaxLength(100)]
        public string Name { get => name; set => name = value; }

        public int Max_rarity { get => max_rarity; set => max_rarity = value; }
        public string Two_piece_bonus { get => two_piece_bonus; set => two_piece_bonus = value; }
        public string Four_piece__bonus { get => four_piece__bonus; set => four_piece__bonus = value; }
    }
}