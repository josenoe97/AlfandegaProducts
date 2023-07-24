using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlfandegaProduct_s.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public List<Product> ListProducts { get; set; } = new List<Product>();

        public Product() { }

        public  Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void AddProduct(Product product) { ListProducts.Add(product); }

        public virtual string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2" , CultureInfo.InvariantCulture) ;
        }
    }
}
