using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GenshinImpact.Models
{
    [Table("Rewards")]
    public class Rewards
    {
        private int id;
        private string day;
        private List<Details> details;

        [Key]
        public int Id { get => id; set => id = value; }

        public string Day { get => day; set => day = value; }
        public List<Details> Details { get => details; set => details = value; }
    }
}