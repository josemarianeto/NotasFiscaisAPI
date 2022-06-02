using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotasFiscaisAPI.Migrations
{
    public partial class category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CategoryID",
                schema: "Notas",
                table: "Items",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "Notas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_CategoryID",
                schema: "Notas",
                table: "Items",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Categories_CategoryID",
                schema: "Notas",
                table: "Items",
                column: "CategoryID",
                principalSchema: "Notas",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Categories_CategoryID",
                schema: "Notas",
                table: "Items");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "Notas");

            migrationBuilder.DropIndex(
                name: "IX_Items_CategoryID",
                schema: "Notas",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                schema: "Notas",
                table: "Items");
        }
    }
}
