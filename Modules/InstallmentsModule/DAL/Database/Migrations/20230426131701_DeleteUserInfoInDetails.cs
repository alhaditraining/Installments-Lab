using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstallmentsModule.DAL.Database.Migrations
{
    public partial class DeleteUserInfoInDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                schema: "InstallmentsModule",
                table: "PaymentPlanDetails");

            migrationBuilder.DropColumn(
                name: "CreatedDatetime",
                schema: "InstallmentsModule",
                table: "PaymentPlanDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedByUserId",
                schema: "InstallmentsModule",
                table: "PaymentPlanDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreatedDatetime",
                schema: "InstallmentsModule",
                table: "PaymentPlanDetails",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
