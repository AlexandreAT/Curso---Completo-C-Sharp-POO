using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Ex7.Entities
{
    public class OrderItem
    {
        public int Quantity {get; set;}
        public double Price {get; set;}
        public Product Product {get; set;}

        public OrderItem(){
        }

        public OrderItem(int quantity, double price, Product product){
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubtTotal(){
            
            return Quantity * Price;

        }

        public override string ToString()
        {
            return Product.Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture) + 
            ", Quantidade: " + Quantity + 
            ", Subtotal: R$" + SubtTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}