using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TDonCashless.Microservices.ValidateToken.API.Migrations
{
    public partial class RemovesUnecessaryField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TokenCreationDate",
                table: "ValidatedTokens");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TokenCreationDate",
                table: "ValidatedTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
