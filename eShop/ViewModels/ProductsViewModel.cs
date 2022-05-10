using eShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.ViewModels
{
    public class ProductsViewModel
    {
        public List<Product> Products;
        public Product Product;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Price { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public string Image { get; set; }
        public Category Category { get; set; }
        public int Quantity { get; set; }
    }
}
