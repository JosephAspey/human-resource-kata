using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accredit.Domain.Migrations
{
    public partial class initalcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HumanResourceStatus",
                columns: table => new
                {
                    HumanResourceStatusId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HumanResourceStatus", x => x.HumanResourceStatusId);
                });

            migrationBuilder.CreateTable(
                name: "HumanResources",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    DepartmentName = table.Column<string>(nullable: true),
                    HumanResourceStatusId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    EmployeeNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HumanResources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HumanResources_HumanResourceStatus_HumanResourceStatusId",
                        column: x => x.HumanResourceStatusId,
                        principalTable: "HumanResourceStatus",
                        principalColumn: "HumanResourceStatusId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "HumanResourceStatus",
                columns: new[] { "HumanResourceStatusId", "Name" },
                values: new object[] { 1, "Approved" });

            migrationBuilder.InsertData(
                table: "HumanResourceStatus",
                columns: new[] { "HumanResourceStatusId", "Name" },
                values: new object[] { 2, "Pending" });

            migrationBuilder.InsertData(
                table: "HumanResourceStatus",
                columns: new[] { "HumanResourceStatusId", "Name" },
                values: new object[] { 3, "Disabled" });

            migrationBuilder.CreateIndex(
                name: "IX_HumanResources_HumanResourceStatusId",
                table: "HumanResources",
                column: "HumanResourceStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HumanResources");

            migrationBuilder.DropTable(
                name: "HumanResourceStatus");
        }
    }
}
