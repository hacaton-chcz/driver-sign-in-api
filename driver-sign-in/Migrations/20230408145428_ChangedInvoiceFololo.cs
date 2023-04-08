using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace driver_sign_in.Migrations
{
    /// <inheritdoc />
    public partial class ChangedInvoiceFololo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Checkpoint",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "Sender",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "StatusUpdatedAt",
                table: "Invoices",
                newName: "MustBeOnCheckUTC");

            migrationBuilder.RenameColumn(
                name: "PassTo",
                table: "Invoices",
                newName: "To");

            migrationBuilder.RenameColumn(
                name: "PassFrom",
                table: "Invoices",
                newName: "StatusUpdatedUTC");

            migrationBuilder.RenameColumn(
                name: "ArivedAt",
                table: "Invoices",
                newName: "From");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Invoices",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "InvoiceId",
                table: "Invoices",
                type: "numeric(20,0)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<float>(
                name: "ProductAmount",
                table: "Invoices",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "ProductAmount",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "To",
                table: "Invoices",
                newName: "PassTo");

            migrationBuilder.RenameColumn(
                name: "StatusUpdatedUTC",
                table: "Invoices",
                newName: "PassFrom");

            migrationBuilder.RenameColumn(
                name: "MustBeOnCheckUTC",
                table: "Invoices",
                newName: "StatusUpdatedAt");

            migrationBuilder.RenameColumn(
                name: "From",
                table: "Invoices",
                newName: "ArivedAt");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Invoices",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddColumn<int>(
                name: "Checkpoint",
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
