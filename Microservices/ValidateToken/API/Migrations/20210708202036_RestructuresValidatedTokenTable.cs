using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TDonCashless.Microservices.ValidateToken.API.Migrations
{
    public partial class RestructuresValidatedTokenTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValidatedTime",
                table: "ValidatedTokens",
                newName: "ValidatedLogTime");

            migrationBuilder.AddColumn<int>(
                name: "CVV",
                table: "ValidatedTokens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "Token",
                table: "ValidatedTokens",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<DateTime>(
                name: "TokenCreationDate",
                table: "ValidatedTokens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CVV",
                table: "ValidatedTokens");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "ValidatedTokens");

            migrationBuilder.DropColumn(
                name: "TokenCreationDate",
                table: "ValidatedTokens");

            migrationBuilder.RenameColumn(
                name: "ValidatedLogTime",
                table: "ValidatedTokens",
                newName: "ValidatedTime");
        }
    }
}
