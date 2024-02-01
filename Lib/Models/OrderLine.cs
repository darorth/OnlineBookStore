using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib.Models
{
    public class OrderLine
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; } = null!;
        public int OrderId { get; set; }
        public Order Order { get; set; } = null!;
        public int DiscountId { get; set; }
        public Discount Discount { get; set; } = null!;
        public int TaxId { get; set; }
        public Taxrates Taxrates { get; set; } = null!;

        public DateTime DetailDate { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountInRiel { get; set; }
        public string Remark { get; set; }
    }
}