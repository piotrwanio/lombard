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
            modelBuilder.Entity<Transaction>().HasData(

                new Transaction
                {
                    TransactionId = 1,
                    TransactionDate = new DateTime(),
                    TransactionType = TransactionType.Purchase

                }
                ,
                new Transaction
                {
                    TransactionId = 2,
                    TransactionDate = new DateTime(),
                    TransactionType = TransactionType.Purchase

                },

                new Transaction
                {
                    TransactionId = 3,
                    TransactionDate = new DateTime(),
                    TransactionType = TransactionType.Sell

                },

                new Transaction
                {
                    TransactionId = 4,
                    TransactionDate = new DateTime(),
                    TransactionType = TransactionType.Sell

                });

            modelBuilder.Entity<Item>().HasData(

                new Item
                {
                    ItemId = 1,
                    Name = "Kubek",
                    Quantity = 2,
                    PurchasePrice = 15
                },

                new Item
                {
                    ItemId = 2,
                    Name = "Długopis",
                    Quantity = 15,
                    PurchasePrice = 5
                },

                new Item
                {
                    ItemId = 3,
                    Name = "Kawa",
                    Quantity = 5,
                    PurchasePrice = 40
                },

                new Item
                {
                    ItemId = 4,
                    Name = "Ciastka",
                    Quantity = 85,
                    PurchasePrice = 2
                },

                new Item
                {
                    ItemId = 5,
                    Name = "Ładowarka",
                    Quantity = 2,
                    PurchasePrice = 30
                },
                new Item
                {
                    ItemId = 6,
                    Name = "Krzesło",
                    Quantity = 6,
                    PurchasePrice = 20
                },
                new Item
                {
                    ItemId = 7,
                    Name = "Piwo",
                    Quantity = 666,
                    PurchasePrice = 6
                },
                new Item
                {
                    ItemId = 8,
                    Name = "Pizza",
                    Quantity = 85,
                    PurchasePrice = 25
                }

                );
            modelBuilder.Entity<TransactionItem>().HasData(
                new TransactionItem
                {
                    TransactionItemId = 1,
                    TransactionId = 1,
                    ItemId = 1
                },

                new TransactionItem
                {
                    TransactionItemId = 2,
                    TransactionId = 1,
                    ItemId = 2
                },

                new TransactionItem
                {
                    TransactionItemId = 3,
                    TransactionId = 2,
                    ItemId = 3
                },

                new TransactionItem
                {
                    TransactionItemId = 4,
                    TransactionId = 2,
                    ItemId = 4
                },

                new TransactionItem
                {
                    TransactionItemId = 5,
                    TransactionId = 3,
                    ItemId = 5
                },

                new TransactionItem
                {
                    TransactionItemId = 6,
                    TransactionId = 3,
                    ItemId = 6
                },

                new TransactionItem
                {
                    TransactionItemId = 7,
                    TransactionId = 4,
                    ItemId = 7
                },

                new TransactionItem
                {
                    TransactionItemId = 8,
                    TransactionId = 4,
                    ItemId = 8
                }                
            );
        }
    }
}
