using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pod.Core.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentStates",
                columns: table => new
                {
                    PaymentStatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    PaymentRequestRequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentStates", x => x.PaymentStatusId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentRequest",
                columns: table => new
                {
                    RequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreditCardNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    CardHolder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SecurityCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentStateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentRequest", x => x.RequestId);
                    table.ForeignKey(
                        name: "FK_PaymentRequest_PaymentStates_PaymentStateId",
                        column: x => x.PaymentStateId,
                        principalTable: "PaymentStates",
                        principalColumn: "PaymentStatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentRequest_PaymentStateId",
                table: "PaymentRequest",
                column: "PaymentStateId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PaymentStates_PaymentRequestRequestId",
                table: "PaymentStates",
                column: "PaymentRequestRequestId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentStates_PaymentRequest_PaymentRequestRequestId",
                table: "PaymentStates",
                column: "PaymentRequestRequestId",
                principalTable: "PaymentRequest",
                principalColumn: "RequestId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentRequest_PaymentStates_PaymentStateId",
                table: "PaymentRequest");

            migrationBuilder.DropTable(
                name: "PaymentStates");

            migrationBuilder.DropTable(
                name: "PaymentRequest");
        }
    }
}
