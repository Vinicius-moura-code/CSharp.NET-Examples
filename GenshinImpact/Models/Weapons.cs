using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinImpact.Models
{
    public class Weapons
    {
        private int id;
        private String name;
        private String slug;
        private String rarity;
        private int atk;
        private String obtain;
        private String type;

        [JsonProperty("id")]
        public int Id { get => id; set => id = value; }

        [JsonProperty("name")]
        public string Name { get => name; set => name = value; }

        [JsonProperty("slug")]
        public string Slug { get => slug; set => slug = value; }

        [JsonProperty("rarity")]
        public string Rarity { get => rarity; set => rarity = value; }

        [JsonProperty("atk")]
        public int Atk { get => atk; set => atk = value; }

        [JsonProperty("obtain")]
        public string Obtain { get => obtain; set => obtain = value; }

        [JsonProperty("type")]
        public string Type { get => type; set => type = value; }
    }
}
