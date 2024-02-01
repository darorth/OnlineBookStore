using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib.Models
{
    public class Author
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Address { get; set; }
        public DateOnly? DeathDate { get; set; }
        public string? Nationality { get; set; }
        public string? PhotoUrl { get; set; }
        public string? Description { get; set; }
    }
}