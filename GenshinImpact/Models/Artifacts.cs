using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinImpact.Models
{
    public class Artifacts
    {
        private int id;
        private String name;
        private String slug;
        private String second_set_bonus;
        private String fourth_set_bonus;

        [Key]
        public int Id { get => id; set => id = value; }

        [Required]
        [MaxLength(100)]
        public string Name { get => name; set => name = value; }

        public string Slug { get => slug; set => slug = value; }

        public string Second_set_bonus { get => second_set_bonus; set => second_set_bonus = value; }

        public string Fourth_set_bonus { get => fourth_set_bonus; set => fourth_set_bonus = value; }
    }
}