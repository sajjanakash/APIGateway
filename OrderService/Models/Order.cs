using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderService.Models
{
    public class Order
    {

        public int OerderId { get; set; }
        public int ProductId { get; set; }
        public string OrderDate{ get; set; }
        public int Quantity { get; set; }
        public int Amount { get; set; }

    }
}
