﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BulkyWeb3.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Range(1,100)]
        public int DisplayOrder { get; set; }
    }
}
