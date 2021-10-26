using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenshinImpact.Models
{
    public class Characters
    {
        private int id;
        private String name;
        private String slug;
        private String description;
        private String gender;
        private String birthday;
        private int rarity;
        private String vision;
        private String weapon;
        private String obtain;

        [JsonProperty("id")]
        public int Id { get => id; set => id = value; }

        [JsonProperty("name")]
        public string Name { get => name; set => name = value; }

        [JsonProperty("slug")]
        public string Slug { get => slug; set => slug = value; }

        [JsonProperty("description")]
        public string Description { get => description; set => description = value; }

        [JsonProperty("gender")]
        public string Gender { get => gender; set => gender = value; }

        [JsonProperty("birthday")]
        public string Birthday { get => birthday; set => birthday = value; }

        [JsonProperty("rarity")]
        public int Rarity { get => rarity; set => rarity = value; }

        [JsonProperty("vision")]
        public string Vision { get => vision; set => vision = value; }

        [JsonProperty("weapon")]
        public string Weapon { get => weapon; set => weapon = value; }

        [JsonProperty("obtain")]
        public string Obtain { get => obtain; set => obtain = value; }
    }
}
