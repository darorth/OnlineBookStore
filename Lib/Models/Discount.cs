using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required decimal Value { get; set; }

        public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
    }
}