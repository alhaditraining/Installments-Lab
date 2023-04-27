using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstallmentsModule.DAL.Database.Migrations
{
    public partial class editTableNameAndUserIdDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentPlanHeader",
                schema: "InstallmentsModule");

            migrationBuilder.DropColumn(
                name: "LastUpdateDatetime",
                schema: "InstallmentsModule",
                table: "PaymentPlanDetails");

            migrationBuilder.RenameColumn(
                name: "LastUpdateByUserId",
                schema: "InstallmentsModule",
                table: "PaymentPlanDetails",
                newName: "PaymentPlanId");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                schema: "InstallmentsModule",
                table: "PaymentPlanDetails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "LastUpdateByUserId",
                schema: "InstallmentsModule",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                schema: "InstallmentsModule",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.CreateTable(
                name: "PaymentPlan",
                schema: "InstallmentsModule",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Datetime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaiedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RemainingAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BillTypeId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BillId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDatetime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdateByUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDatetime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentPlan", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentPlanDetails_PaymentPlanId",
                schema: "InstallmentsModule",
                table: "PaymentPlanDetails",
                column: "PaymentPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentPlanDetails_PaymentPlan_PaymentPlanId",
                schema: "InstallmentsModule",
                table: "PaymentPlanDetails",
                column: "PaymentPlanId",
                principalSchema: "InstallmentsModule",
                principalTable: "PaymentPlan",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentPlanDetails_PaymentPlan_PaymentPlanId",
                schema: "InstallmentsModule",
                table: "PaymentPlanDetails");

            migrationBuilder.DropTable(
                name: "PaymentPlan",
                schema: "InstallmentsModule");

            migrationBuilder.DropIndex(
                name: "IX_PaymentPlanDetails_PaymentPlanId",
                schema: "InstallmentsModule",
                table: "PaymentPlanDetails");

            migrationBuilder.RenameColumn(
                name: "PaymentPlanId",
                schema: "InstallmentsModule",
                table: "PaymentPlanDetails",
                newName: "LastUpdateByUserId");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByUserId",
                schema: "InstallmentsModule",
                table: "PaymentPlanDetails",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LastUpdateDatetime",
                schema: "InstallmentsModule",
                table: "PaymentPlanDetails",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "LastUpdateByUserId",
                schema: "InstallmentsModule",
                table: "Accounts",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedByUserId",
                schema: "InstallmentsModule",
                table: "Accounts",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "PaymentPlanHeader",
                schema: "InstallmentsModule",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BillId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillTypeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDatetime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Datetime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdateByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastUpdateDatetime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    PaiedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RemainingAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentPlanHeader", x => x.Id);
                });
        }
    }
}
