using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace Infra_.Db
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {  }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categorys { get; set; }

        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Currency> Currencys { get; set; }
        public DbSet<Configure> Configures { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Delivery> Deliverys { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentLog> PaymentLogs { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<PaymentStatus> PaymentStatus { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Taxrates> Taxrates { get; set; }

    }
}