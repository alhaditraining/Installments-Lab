using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstallmentsModule.DAL.Database.Migrations
{
    public partial class RenameAmountToTotolAmount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RemainingAmount",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                newName: "TotalRemainingAmount");

            migrationBuilder.RenameColumn(
                name: "PaiedAmount",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                newName: "TotalPaiedAmount");

            migrationBuilder.RenameColumn(
                name: "Amount",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                newName: "TotalAmount");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalRemainingAmount",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                newName: "RemainingAmount");

            migrationBuilder.RenameColumn(
                name: "TotalPaiedAmount",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                newName: "PaiedAmount");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                newName: "Amount");
        }
    }
}
