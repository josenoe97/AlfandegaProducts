using AlfandegaProduct_s.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlfandegaProduct_s.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct() { }

        public  ImportedProduct(string name, double price, double customFee) 
            : base(name, price)
        {
            if (customFee < 0)
            {
                throw new DomainException($"{customFee} is a negative value");
            }
            CustomFee = customFee;
        }

        public override string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + "(Customs fee: $ " + CustomFee.ToString("F2" , CultureInfo.InvariantCulture) + ")";
        }
    }
}
