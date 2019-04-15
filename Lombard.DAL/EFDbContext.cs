using Lombard.DAL.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lombard.DAL
{
    public class EFDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<TransactionItem> TransactionsItems { get; set; }

        public EFDbContext(DbContextOptions<EFDbContext> options) : base(options)
        {
        }

        public EFDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=d:/Database.db");
        }
    }
}
