using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BireCokOrnek.Data.Migrations
{
    public partial class Ilk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departmanlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmanlar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Calisanlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calisanlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Calisanlar_Departmanlar_DepartmanId",
                        column: x => x.DepartmanId,
                        principalTable: "Departmanlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departmanlar",
                columns: new[] { "Id", "Ad" },
                values: new object[,]
                {
                    { 1, "Muhasebe" },
                    { 2, "Bilgi İşlem" },
                    { 3, "Satış ve Pazarlama" },
                    { 4, "Ar-Ge" }
                });

            migrationBuilder.InsertData(
                table: "Calisanlar",
                columns: new[] { "Id", "Ad", "DepartmanId", "Soyad" },
                values: new object[,]
                {
                    { 1, "Ali", 1, "Öz" },
                    { 2, "Can", 2, "Demir" },
                    { 3, "Cem", 2, "Kaya" },
                    { 4, "Ece", 3, "Şahin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Calisanlar_DepartmanId",
                table: "Calisanlar",
                column: "DepartmanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calisanlar");

            migrationBuilder.DropTable(
                name: "Departmanlar");
        }
    }
}
