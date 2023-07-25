using AlfandegaProduct_s.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlfandegaProduct_s.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate) 
            : base(name, price) 
        {
            DateTime now = DateTime.Now;
            if(manufactureDate > now)
            {
                throw new DomainException($"{manufactureDate} is greater than the current one");
            }
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return Name + " (used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }
    }
}
