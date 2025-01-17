using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Poyecto.Migrations
{
    /// <inheritdoc />
    public partial class prueba10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personajes_tvs_tvid",
                table: "personajes");

            migrationBuilder.AlterColumn<int>(
                name: "tvid",
                table: "personajes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_personajes_tvs_tvid",
                table: "personajes",
                column: "tvid",
                principalTable: "tvs",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personajes_tvs_tvid",
                table: "personajes");

            migrationBuilder.AlterColumn<int>(
                name: "tvid",
                table: "personajes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_personajes_tvs_tvid",
                table: "personajes",
                column: "tvid",
                principalTable: "tvs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
