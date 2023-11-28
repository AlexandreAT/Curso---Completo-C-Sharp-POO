using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex9.Entities
{
    public class UsedProduct : Product
    {

        public DateTime ManufactureDate {get; set;}

        public UsedProduct(){
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price) {

            ManufactureDate = manufactureDate;

        }

        public override string PriceTag()
        {
            return "Produto: "+Name+" (usado) $ "+Price.ToString("F2", CultureInfo.InvariantCulture)+" (data de fabricação: "+ManufactureDate.ToString("dd/MM/yyyy")+")";
        }

    }
}