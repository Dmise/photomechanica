using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    
    public static class TestConsole
    {
        private static ILogger Log;
        public static void Run()
        {

        }

        public static IEnumerable<Order> GetOrdersWithShipments(IEnumerable<Order> orders, IEnumerable<Shipment> shipments)
        {
            var result = new List<Order>();
            if (orders.Count() == 0) 
            {
                return result;
            }
            
            foreach (var order in orders) 
            {
                Log.LogDebug($"Start working on order {order.OrderId}");

                if (order.ShipmenеId == null) continue;

                var ship = shipments.FirstOrDefault(s => s.ShipmentId == order.ShipmenеId);

                if (ship.ShipmentAddress == null) continue;

                result.Add(order);
            }
          
            return result;
        } 
    }


    public class Order
    {
        public int OrderId { get; set; }   
        public int? ShipmenеId { get; set; }
    }

    public class Shipment
    {
        public int ShipmentId { get; set; }
        public string ShipmentAddress { get; set; }
    }
}
