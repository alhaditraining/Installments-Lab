using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstallmentsModule.DAL.Database.Migrations
{
    public partial class AddAccountIdToPaymentPlan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountId",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountId",
                schema: "InstallmentsModule",
                table: "PaymentPlan");
        }
    }
}
