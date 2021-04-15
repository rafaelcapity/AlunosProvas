using Microsoft.EntityFrameworkCore.Migrations;

namespace AlunosProvas.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alunos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    idade = table.Column<int>(type: "int", nullable: false),
                    bolsista = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alunos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Alunos",
                columns: new[] { "Id", "bolsista", "city", "cpf", "idade", "nome" },
                values: new object[,]
                {
                    { 1, false, "RP", "656565656", 28, "Andre" },
                    { 2, true, "SJC", "656565656", 28, "Andre" },
                    { 3, false, "SP", "656565656", 28, "Andre" },
                    { 4, false, "SJC", "656565656", 28, "Andre" },
                    { 5, true, "Franca", "656565656", 28, "Andre" },
                    { 6, false, "SJC", "656565656", 28, "Andre" },
                    { 7, false, "SP", "656565656", 28, "Andre" },
                    { 8, true, "SP", "656565656", 28, "Andre" },
                    { 9, false, "SJC", "656565656", 28, "Andre" },
                    { 10, true, "Franca", "656565656", 28, "Andre" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alunos");
        }
    }
}
