using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib.Models
{
    public class Customer : Person
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Address { get; set; }
        // public string? Phone { get; set; }
        // public string? Email { get; set; }
        public string? Remark { get; set; }

        public List<Order> Orders { get; set; } = new List<Order>();
    }
}