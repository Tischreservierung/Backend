﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Core.Models.User
{
    [Index(nameof(EMail), IsUnique = true)]
    public class Person : EntityObject
    {
        public string Name { get; set; } = string.Empty;
        public string FamilyName { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public string EMail { get; set; } = string.Empty;
    }
}
