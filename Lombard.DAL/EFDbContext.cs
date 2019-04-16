using Lombard.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;

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
            optionsBuilder.UseSqlite("Data Source=e:/Database.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>().HasData(new Transaction {
                TransactionId = 1,
                TransactionDate = new DateTime()
            });
            modelBuilder.Entity<Item>().HasData(new Item {
                ItemId = 1,
                Name = "Kubek",
                Quantity = 2,
                PurchasePrice = 100
            },
            new Item
            {
                ItemId = 2,
                Name = "Kubek2",
                Quantity = 2,
                PurchasePrice = 100
            });
            modelBuilder.Entity<TransactionItem>().HasData(new TransactionItem
            {
                TransactionItemId = 1,
                TransactionId = 1,
                ItemId = 2
            },
            new TransactionItem
            {
                TransactionItemId = 2,
                TransactionId = 1,
                ItemId = 1
            }
            );
        }
    }
}
