using System;
using System.Collections.Generic;

namespace eShop.Models
{
    public partial class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public double? Price { get; set; }
        public int? Quantity { get; set; }
        public double? TotalAmount { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
