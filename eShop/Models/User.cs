using System;
using System.Collections.Generic;

namespace eShop.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
        }

        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? FullName { get; set; }
        public string AccountType { get; set; } = null!;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
