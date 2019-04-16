using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lombard.DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TransactionType = table.Column<int>(nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    PurchasePrice = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    Unit = table.Column<string>(nullable: true),
                    SellingPrice = table.Column<decimal>(nullable: false),
                    TransactionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                    table.ForeignKey(
                        name: "FK_Items_Transactions_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "Transactions",
                        principalColumn: "TransactionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TransactionsItems",
                columns: table => new
                {
                    TransactionItemId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TransactionId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionsItems", x => x.TransactionItemId);
                    table.ForeignKey(
                        name: "FK_TransactionsItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TransactionsItems_Transactions_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "Transactions",
                        principalColumn: "TransactionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Name", "PurchasePrice", "Quantity", "SellingPrice", "TransactionId", "Unit" },
                values: new object[] { 1, "Kubek", 100m, 2.0, 0m, null, null });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "Name", "PurchasePrice", "Quantity", "SellingPrice", "TransactionId", "Unit" },
                values: new object[] { 2, "Kubek2", 100m, 2.0, 0m, null, null });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "TransactionId", "TransactionDate", "TransactionType" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 });

            migrationBuilder.InsertData(
                table: "TransactionsItems",
                columns: new[] { "TransactionItemId", "ItemId", "TransactionId" },
                values: new object[] { 1, 2, 1 });

            migrationBuilder.InsertData(
                table: "TransactionsItems",
                columns: new[] { "TransactionItemId", "ItemId", "TransactionId" },
                values: new object[] { 2, 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Items_TransactionId",
                table: "Items",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionsItems_ItemId",
                table: "TransactionsItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TransactionsItems_TransactionId",
                table: "TransactionsItems",
                column: "TransactionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactionsItems");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
