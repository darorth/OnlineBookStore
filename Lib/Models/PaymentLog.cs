using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib.Models
{
    public class PaymentLog
    {
        public int Id { get; set; }
        public required DateTime Timestamp { get; set; }
        public required string LogMessage { get; set; }
        public string? Remark { get; set; }
    }
}