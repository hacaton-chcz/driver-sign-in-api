using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace driver_sign_in.Migrations
{
    /// <inheritdoc />
    public partial class ChangedCarDtos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Checkpoint",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "IsArrived",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "Product",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "Sender",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "isChecked",
                table: "Cars",
                newName: "IsChecked");

            migrationBuilder.RenameColumn(
                name: "CarNumber",
                table: "Cars",
                newName: "Number");

            migrationBuilder.AlterColumn<long>(
                name: "CarNumber",
                table: "Invoices",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<DateTime>(
                name: "At",
                table: "Invoices",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "From",
                table: "Invoices",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "At",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "From",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "IsChecked",
                table: "Cars",
                newName: "isChecked");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Cars",
                newName: "CarNumber");

            migrationBuilder.AlterColumn<int>(
                name: "CarNumber",
                table: "Invoices",
                type: "integer",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<int>(
                name: "Checkpoint",
                table: "Invoices",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsArrived",
                table: "Invoices",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Product",
                table: "Invoices",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Invoices",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Sender",
                table: "Invoices",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
