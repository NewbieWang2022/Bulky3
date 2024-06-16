﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BulkyWeb3.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}