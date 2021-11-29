using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Accredit.Domain.Migrations
{
    public partial class ExtendSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HumanResources",
                keyColumn: "Id",
                keyValue: new Guid("b324046e-fcdd-4133-bb16-7f39ebbd2f0a"));

            migrationBuilder.DeleteData(
                table: "HumanResources",
                keyColumn: "Id",
                keyValue: new Guid("b76758c4-0209-49cf-b33c-5117e64ec254"));

            migrationBuilder.InsertData(
                table: "HumanResources",
                columns: new[] { "Id", "CreatedDate", "DateOfBirth", "DepartmentName", "Email", "EmployeeNumber", "FirstName", "HumanResourceStatusId", "LastName" },
                values: new object[,]
                {
                    { new Guid("c975dda4-77a4-459a-8454-4cad23bfc5d5"), new DateTime(2021, 11, 29, 22, 32, 56, 850, DateTimeKind.Local).AddTicks(4225), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "jbloggs@hr.com", "01", "Joe", 1, "Bloggs" },
                    { new Guid("f6ae1fdf-9aa0-4606-8ead-c13ae4c5340b"), new DateTime(2021, 11, 29, 22, 32, 56, 851, DateTimeKind.Local).AddTicks(568), new DateTime(2002, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sales", "hpatel@hr.com", "03", "Harvey", 3, "Patel" },
                    { new Guid("156d294c-5636-467e-90c7-7cbcbb14e6a6"), new DateTime(2021, 11, 29, 22, 32, 56, 851, DateTimeKind.Local).AddTicks(670), new DateTime(1984, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "shayes@hr.com", "03", "Simon", 1, "Hayes" },
                    { new Guid("2e8a2917-3ce0-4c93-ba64-129e80b42f71"), new DateTime(2021, 11, 29, 22, 32, 56, 851, DateTimeKind.Local).AddTicks(685), new DateTime(1978, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "zmurphy@hr.com", "04", "Zoe", 2, "Murphy" },
                    { new Guid("ba65a8bf-ed2a-4dff-bdd7-86ff59205263"), new DateTime(2021, 11, 29, 22, 32, 56, 851, DateTimeKind.Local).AddTicks(699), new DateTime(1994, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Call Center", "chawkins@hr.com", "05", "Charlie", 1, "Hawkins" },
                    { new Guid("44448dc6-daf6-4728-92df-c54e6aebd955"), new DateTime(2021, 11, 29, 22, 32, 56, 851, DateTimeKind.Local).AddTicks(712), new DateTime(1982, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "abishop@hr.com", "06", "Alisha", 1, "Bishop" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HumanResources",
                keyColumn: "Id",
                keyValue: new Guid("156d294c-5636-467e-90c7-7cbcbb14e6a6"));

            migrationBuilder.DeleteData(
                table: "HumanResources",
                keyColumn: "Id",
                keyValue: new Guid("2e8a2917-3ce0-4c93-ba64-129e80b42f71"));

            migrationBuilder.DeleteData(
                table: "HumanResources",
                keyColumn: "Id",
                keyValue: new Guid("44448dc6-daf6-4728-92df-c54e6aebd955"));

            migrationBuilder.DeleteData(
                table: "HumanResources",
                keyColumn: "Id",
                keyValue: new Guid("ba65a8bf-ed2a-4dff-bdd7-86ff59205263"));

            migrationBuilder.DeleteData(
                table: "HumanResources",
                keyColumn: "Id",
                keyValue: new Guid("c975dda4-77a4-459a-8454-4cad23bfc5d5"));

            migrationBuilder.DeleteData(
                table: "HumanResources",
                keyColumn: "Id",
                keyValue: new Guid("f6ae1fdf-9aa0-4606-8ead-c13ae4c5340b"));

            migrationBuilder.InsertData(
                table: "HumanResources",
                columns: new[] { "Id", "CreatedDate", "DateOfBirth", "DepartmentName", "Email", "EmployeeNumber", "FirstName", "HumanResourceStatusId", "LastName" },
                values: new object[] { new Guid("b324046e-fcdd-4133-bb16-7f39ebbd2f0a"), new DateTime(2021, 11, 28, 20, 56, 43, 495, DateTimeKind.Local).AddTicks(7023), new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT", "jbloggs@hr.com", "01", "Joe Bloggs", 1, "Bloggs" });

            migrationBuilder.InsertData(
                table: "HumanResources",
                columns: new[] { "Id", "CreatedDate", "DateOfBirth", "DepartmentName", "Email", "EmployeeNumber", "FirstName", "HumanResourceStatusId", "LastName" },
                values: new object[] { new Guid("b76758c4-0209-49cf-b33c-5117e64ec254"), new DateTime(2021, 11, 28, 20, 56, 43, 496, DateTimeKind.Local).AddTicks(6713), new DateTime(1984, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marketing", "shayes@hr.com", "02", "Simon", 3, "Hayes" });
        }
    }
}
