using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accredit.Domain.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HumanResources",
                columns: new[] { "Id", "CreatedDate", "DateOfBirth", "DepartmentName", "Email", "EmployeeNumber", "FirstName", "HumanResourceStatusId", "LastName" },
                values: new object[] { new Guid("b324046e-fcdd-4133-bb16-7f39ebbd2f0a"), new DateTime(2021, 11, 28, 20, 56, 43, 495, DateTimeKind.Local).AddTicks(7023), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "jbloggs@hr.com", "01", "Joe Bloggs", 1, "Bloggs" });

            migrationBuilder.InsertData(
                table: "HumanResources",
                columns: new[] { "Id", "CreatedDate", "DateOfBirth", "DepartmentName", "Email", "EmployeeNumber", "FirstName", "HumanResourceStatusId", "LastName" },
                values: new object[] { new Guid("b76758c4-0209-49cf-b33c-5117e64ec254"), new DateTime(2021, 11, 28, 20, 56, 43, 496, DateTimeKind.Local).AddTicks(6713), new DateTime(1984, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "shayes@hr.com", "02", "Simon", 3, "Hayes" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HumanResources",
                keyColumn: "Id",
                keyValue: new Guid("b324046e-fcdd-4133-bb16-7f39ebbd2f0a"));

            migrationBuilder.DeleteData(
                table: "HumanResources",
                keyColumn: "Id",
                keyValue: new Guid("b76758c4-0209-49cf-b33c-5117e64ec254"));
        }
    }
}
