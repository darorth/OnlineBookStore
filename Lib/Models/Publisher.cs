using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Phone { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? PhotoUrl { get; set; }
        public string? Remark { get; set; }
    }
}