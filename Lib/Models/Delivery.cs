using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib.Models
{
    public class Delivery
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;
        public required string Address { get; set; }
        public required DateTime ShippingDate { get; set; }
        public DateTime? EstimatedArrivalDate { get; set; }
    }
}