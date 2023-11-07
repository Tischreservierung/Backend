﻿using System.Text.Json.Serialization;

namespace Core.Models
{
    public class Category : EntityObject
    {
        public string Name { get; set; } = string.Empty;

        [JsonIgnore]
        public List<Restaurant> Restaurants { get; set; } = new List<Restaurant>();
    }
}
