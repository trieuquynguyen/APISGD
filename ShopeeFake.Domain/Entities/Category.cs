﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ShopeeFake.Domain.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public Category()
        {
            Products = new HashSet<Product>();
        }
    }
}
