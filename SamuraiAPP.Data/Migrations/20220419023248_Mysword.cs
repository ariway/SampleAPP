using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SamuraiAPP.Data.Migrations
{
    public partial class Mysword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SwordInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TahunPembuatan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nama = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Berat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SwordInfos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SwordInfos");
        }
    }
}
