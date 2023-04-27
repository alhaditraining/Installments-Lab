using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InstallmentsModule.DAL.Database.Migrations
{
    public partial class initiale : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "InstallmentsModule");

            migrationBuilder.CreateTable(
                name: "Accounts",
                schema: "InstallmentsModule",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RefId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDatetime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdateByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastUpdateDatetime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentPlanDetails",
                schema: "InstallmentsModule",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HeaderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaiedDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDatetime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdateByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastUpdateDatetime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentPlanDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentPlanHeader",
                schema: "InstallmentsModule",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Datetime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaiedAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RemainingAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BillTypeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDatetime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastUpdateByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastUpdateDatetime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentPlanHeader", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts",
                schema: "InstallmentsModule");

            migrationBuilder.DropTable(
                name: "PaymentPlanDetails",
                schema: "InstallmentsModule");

            migrationBuilder.DropTable(
                name: "PaymentPlanHeader",
                schema: "InstallmentsModule");
        }
    }
}
