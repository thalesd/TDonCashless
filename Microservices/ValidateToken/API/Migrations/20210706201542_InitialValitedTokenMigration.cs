using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TDonCashless.Microservices.ValidateToken.API.Migrations
{
    public partial class InitialValitedTokenMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ValidatedTokens",
                columns: table => new
                {
                    ValidatedTokenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CardId = table.Column<int>(type: "int", nullable: false),
                    Valid = table.Column<bool>(type: "bit", nullable: false),
                    ValidatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValidatedTokens", x => x.ValidatedTokenId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ValidatedTokens");
        }
    }
}
