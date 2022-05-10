using System;
using System.Collections.Generic;

namespace eShop.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; } = null!;
        public string? Brand { get; set; }
        public double? Price { get; set; }
        public string? Color { get; set; }
        public string? Material { get; set; }
        public string? Image { get; set; }

        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
