using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib.Models
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public required PaymentMethodEnum Name { get; set; }
        public string? Remark { get; set; }
    }
}