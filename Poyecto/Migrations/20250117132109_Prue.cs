using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Poyecto.Migrations
{
    /// <inheritdoc />
    public partial class Prue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tvs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    creacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estrellas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tvs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "personajes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    edad = table.Column<int>(type: "int", nullable: false),
                    peso = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    historia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tvid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personajes", x => x.id);
                    table.ForeignKey(
                        name: "FK_personajes_tvs_tvid",
                        column: x => x.tvid,
                        principalTable: "tvs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_personajes_tvid",
                table: "personajes",
                column: "tvid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personajes");

            migrationBuilder.DropTable(
                name: "tvs");
        }
    }
}
