using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoFinalLeo.Migrations
{
    public partial class InicioPF1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ColaboradorSexo",
                table: "Colaborador",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ColaboradorSexo",
                table: "Colaborador",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
