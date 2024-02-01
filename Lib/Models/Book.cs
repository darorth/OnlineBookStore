using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; } = null!;
        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;
        public required string Name { get; set; }
        public required int ISBN { get; set; }
        public required decimal Price { get; set; }
        public int? Year { get; set; }
        public string? Genre { get; set; }
        public string? Edition { get; set; }
        public int? Pages { get; set; }
        public int? Rating { get; set; }

        public List<OrderLine> OrderLines { get; set; } = new List<OrderLine>();
        public List<Category> Categories { get; set; } = [];
    }
}