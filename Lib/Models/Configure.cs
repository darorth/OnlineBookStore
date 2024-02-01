using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib.Models
{
    public class Configure
    {
        public int Id { get; set; } 
        public required string Name { get; set; }
        public required string Value { get; set; }
        public string? Remark { get; set; }
        
    }
}