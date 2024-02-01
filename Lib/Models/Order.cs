using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public required string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.UtcNow;
        public string? Remark { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalInRiel { get; set; }

        public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
    }
}