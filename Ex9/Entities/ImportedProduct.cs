using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Ex9.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee {get; set;}

        public ImportedProduct(){
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price) {

            CustomsFee = customsFee;

        }

        public override string PriceTag()
        {
            return "Produto: "+Name+" $ "+Price.ToString("F2", CultureInfo.InvariantCulture)+" (taxa de alfândega: "+CustomsFee.ToString("F2", CultureInfo.InvariantCulture)+")";
        }

    }
}