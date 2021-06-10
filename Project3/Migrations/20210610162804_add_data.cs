using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project3.Migrations
{
    public partial class add_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Magazin",
                columns: new[] { "ID", "Denumire", "Pret", "Specificatii", "Status" },
                values: new object[] { new Guid("57ea92ff-5ac7-4f49-b327-08aa85ac132c"), "Nvidia GTX1650", 0, "Placa video Nvidia GTX 1650, 4GB RAM", "Ultimele doua produse" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Magazin",
                keyColumn: "ID",
                keyValue: new Guid("57ea92ff-5ac7-4f49-b327-08aa85ac132c"));
        }
    }
}
