using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstallmentsModule.DAL.Database.Migrations
{
    public partial class AddPaiedAmountAndRemainingAmount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PaiedAmount",
                schema: "InstallmentsModule",
                table: "PaymentPlanDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "RemainingAmount",
                schema: "InstallmentsModule",
                table: "PaymentPlanDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaiedAmount",
                schema: "InstallmentsModule",
                table: "PaymentPlanDetails");

            migrationBuilder.DropColumn(
                name: "RemainingAmount",
                schema: "InstallmentsModule",
                table: "PaymentPlanDetails");
        }
    }
}
