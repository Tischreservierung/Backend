﻿using Core.Models;

namespace Core.Dto
{
    public class RestaurantDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public RestaurantPicture? Picture { get; set; }
    }
}
