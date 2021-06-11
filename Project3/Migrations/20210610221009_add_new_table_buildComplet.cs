using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project3.Migrations
{
    public partial class add_new_table_buildComplet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuildComplet",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumeClient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Componente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataComenzii = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PretTotal = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildComplet", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuildComplet");
        }
    }
}
