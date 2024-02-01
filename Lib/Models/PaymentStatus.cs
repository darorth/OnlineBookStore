using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib.Models
{
    public class PaymentStatus
    {
        public int Id { get; set; }
        public required PaymentStatusEnum Name { get; set; }
        public string? Remark { get; set; }
    }
}