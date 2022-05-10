using System;
using System.Collections.Generic;

namespace eShop.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public string? DeliveryAddress { get; set; }
        public DateTime DateTime { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
