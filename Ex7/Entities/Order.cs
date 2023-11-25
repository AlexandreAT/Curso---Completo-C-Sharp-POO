using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Ex7.Entities.Enums;
using System.Globalization;

namespace Ex7.Entities
{
    public class Order
    {
        public DateTime Moment {get; set;}
        public OrderStatus Status {get; set;}
        public List<OrderItem> Item {get; set;} = new List<OrderItem>();
        public Client Client {get; set;}

        public Order(){
        }

        public Order(DateTime moment, OrderStatus status, Client client){
            Status = status;
            Client = client;
            Moment = moment;
        }

        public void AddItem(OrderItem item){
            Item.Add(item);
        }

        public void RemoveItem(OrderItem item){
            Item.Remove(item);
        }

        public double Total(){

            double total = 0;

            foreach (OrderItem item in Item){
                total += item.SubtTotal();
            }
            return total;

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Momento do pedido: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Status do pedido: " + Status);
            sb.AppendLine("Cliente: " + Client);
            sb.AppendLine("Items do pedido:");
            foreach (OrderItem item in Item)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}