using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstallmentsModule.DAL.Database.Migrations
{
    public partial class RenameAccountIdTAccountRefId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AccountId",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                newName: "AccountRefId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AccountRefId",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                newName: "AccountId");
        }
    }
}
