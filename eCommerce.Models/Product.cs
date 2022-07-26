﻿using System.ComponentModel.DataAnnotations;

namespace eCommerce.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Description { get; set; }
        public string Image { get; set; }
        public Category category {get; set;}

    }
}
