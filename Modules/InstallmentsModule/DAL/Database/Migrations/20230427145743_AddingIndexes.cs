using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstallmentsModule.DAL.Database.Migrations
{
    public partial class AddingIndexes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateByUserId",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BillTypeId",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BillId",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountRefId",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateByUserId",
                schema: "InstallmentsModule",
                table: "Accounts",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                schema: "InstallmentsModule",
                table: "Accounts",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPlan_AccountRefId",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                column: "AccountRefId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPlan_BillId_BillTypeId",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                columns: new[] { "BillId", "BillTypeId" },
                unique: true,
                filter: "BillId IS NOT NULL and BillTypeId IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPlan_CreatedByUserId",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPlan_CreatedDatetime",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                column: "CreatedDatetime");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPlan_Datetime",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                column: "Datetime");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPlan_LastUpdateByUserId",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                column: "LastUpdateByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPlan_LastUpdateDatetime",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                column: "LastUpdateDatetime");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_CreatedByUserId",
                schema: "InstallmentsModule",
                table: "Accounts",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_CreatedDatetime",
                schema: "InstallmentsModule",
                table: "Accounts",
                column: "CreatedDatetime");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_LastUpdateByUserId",
                schema: "InstallmentsModule",
                table: "Accounts",
                column: "LastUpdateByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_LastUpdateDatetime",
                schema: "InstallmentsModule",
                table: "Accounts",
                column: "LastUpdateDatetime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PaymentPlan_AccountRefId",
                schema: "InstallmentsModule",
                table: "PaymentPlan");

            migrationBuilder.DropIndex(
                name: "IX_PaymentPlan_BillId_BillTypeId",
                schema: "InstallmentsModule",
                table: "PaymentPlan");

            migrationBuilder.DropIndex(
                name: "IX_PaymentPlan_CreatedByUserId",
                schema: "InstallmentsModule",
                table: "PaymentPlan");

            migrationBuilder.DropIndex(
                name: "IX_PaymentPlan_CreatedDatetime",
                schema: "InstallmentsModule",
                table: "PaymentPlan");

            migrationBuilder.DropIndex(
                name: "IX_PaymentPlan_Datetime",
                schema: "InstallmentsModule",
                table: "PaymentPlan");

            migrationBuilder.DropIndex(
                name: "IX_PaymentPlan_LastUpdateByUserId",
                schema: "InstallmentsModule",
                table: "PaymentPlan");

            migrationBuilder.DropIndex(
                name: "IX_PaymentPlan_LastUpdateDatetime",
                schema: "InstallmentsModule",
                table: "PaymentPlan");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_CreatedByUserId",
                schema: "InstallmentsModule",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_CreatedDatetime",
                schema: "InstallmentsModule",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_LastUpdateByUserId",
                schema: "InstallmentsModule",
                table: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_LastUpdateDatetime",
                schema: "InstallmentsModule",
                table: "Accounts");

            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateByUserId",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "BillTypeId",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BillId",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AccountRefId",
                schema: "InstallmentsModule",
                table: "PaymentPlan",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateByUserId",
                schema: "InstallmentsModule",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                schema: "InstallmentsModule",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
