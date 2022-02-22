using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeliuEshop_projektas.Migrations
{
    public partial class preke : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Prekes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Vardas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nuotrauka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aprasymas = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kaina = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prekes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Prekes");
        }
    }
}
