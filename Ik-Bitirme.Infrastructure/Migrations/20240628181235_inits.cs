using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ik_Bitirme.Infrastructure.Migrations
{
    public partial class inits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "CreateDate", "HireDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2024, 6, 28, 21, 12, 35, 231, DateTimeKind.Local).AddTicks(2419), "ac8c8de3-4fe9-46b2-8cae-b4d992c84e84", new DateTime(2024, 6, 28, 21, 12, 35, 231, DateTimeKind.Local).AddTicks(2418), new DateTime(2024, 6, 28, 21, 12, 35, 231, DateTimeKind.Local).AddTicks(2420), "AQAAAAEAACcQAAAAEO9llzzQLthqMWTS2hNOmCLxxhobcJzONlAulYUQnzk1xTBhRm1qnAMPwoBg5ImBxw==", "34acba89-3c6d-46d5-8016-099d4644726f" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "BirthPlace", "ConcurrencyStamp", "CreateDate", "DeleteDate", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FirstName", "HireDate", "ImageData", "JobId", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Salary", "SecondLastName", "SecurityStamp", "Status", "TcIdentity", "TerminationDate", "TwoFactorEnabled", "UpdateDate", "UserName" },
                values: new object[] { "1", 0, "abc", new DateTime(2024, 6, 28, 21, 12, 35, 228, DateTimeKind.Local).AddTicks(8338), "aaa", "f0175655-8332-4700-ae81-386e4f12e533", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "Admin", "admin@example.com", true, "admin", new DateTime(2024, 6, 28, 21, 12, 35, 228, DateTimeKind.Local).AddTicks(8340), null, 1, "admin", false, null, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAEAACcQAAAAEFnBIcOYGpHz9SvmsMFNn7O+ZpJ2CDrzKWU0QraaRwiXt+yfin9yINjTq3yr+DDFJg==", "1234567890", false, 123m, null, "8a878e97-8f3c-4cb8-abd9-58f3ec05a4cc", 0, "123123", null, false, null, "admin" });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "CompanyId",
                keyValue: 1,
                columns: new[] { "ContractEndDate", "ContractStartDate", "CreateDate", "YearOfEstablishment" },
                values: new object[] { new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(329), new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(328), new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(326), new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(330) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "CompanyId",
                keyValue: 2,
                columns: new[] { "ContractEndDate", "ContractStartDate", "CreateDate", "YearOfEstablishment" },
                values: new object[] { new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(333), new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(332), new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(331), new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(334) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "CompanyId",
                keyValue: 3,
                columns: new[] { "ContractEndDate", "ContractStartDate", "CreateDate", "YearOfEstablishment" },
                values: new object[] { new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(336), new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(336), new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(335), new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(337) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "CompanyId",
                keyValue: 4,
                columns: new[] { "ContractEndDate", "ContractStartDate", "CreateDate", "YearOfEstablishment" },
                values: new object[] { new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(339), new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(339), new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(338), new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(340) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "CompanyId",
                keyValue: 5,
                columns: new[] { "ContractEndDate", "ContractStartDate", "CreateDate", "YearOfEstablishment" },
                values: new object[] { new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(343), new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(342), new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(341), new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(310));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 6, 28, 21, 12, 35, 230, DateTimeKind.Local).AddTicks(362));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "BirthDate", "ConcurrencyStamp", "CreateDate", "HireDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { new DateTime(2024, 5, 9, 12, 29, 47, 146, DateTimeKind.Local).AddTicks(2260), "e9003fc4-42c8-4944-9da1-8c2fa0fc0625", new DateTime(2024, 5, 9, 12, 29, 47, 146, DateTimeKind.Local).AddTicks(2252), new DateTime(2024, 5, 9, 12, 29, 47, 146, DateTimeKind.Local).AddTicks(2261), "AQAAAAEAACcQAAAAEFNnaecIIOFOG5QZw1Te/rAJNkmYWfyuidB2sviuPfXilKVSauMBvV/15Ik0+hnXfQ==", "e7b9f979-7e25-4375-8d35-a122f115a31e" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "BirthPlace", "ConcurrencyStamp", "CreateDate", "DeleteDate", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FirstName", "HireDate", "ImageData", "JobId", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Salary", "SecondLastName", "SecurityStamp", "Status", "TcIdentity", "TerminationDate", "TwoFactorEnabled", "UpdateDate", "UserName" },
                values: new object[] { "1", 0, "abc", new DateTime(2024, 5, 9, 12, 29, 47, 125, DateTimeKind.Local).AddTicks(7894), "aaa", "5e317c6c-7b0f-4e62-950c-752e5fbfb0be", new DateTime(2024, 5, 9, 12, 29, 47, 125, DateTimeKind.Local).AddTicks(7883), null, 1, "AppUser", "admin@example.com", true, "admin", new DateTime(2024, 5, 9, 12, 29, 47, 125, DateTimeKind.Local).AddTicks(7896), null, 1, "admin", false, null, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAEAACcQAAAAELxcE4RhsT6aMVtz65IrlWDSliRE1MQwXTqsqcShABM6H8B8dhaWCfngX26YlciQDg==", "1234567890", false, 123m, null, "d7ec37b9-36e7-40cc-9877-e519c8ea6c5b", 1, "123123", null, false, null, "admin" });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "CompanyId",
                keyValue: 1,
                columns: new[] { "ContractEndDate", "ContractStartDate", "CreateDate", "YearOfEstablishment" },
                values: new object[] { new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6171), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6170), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6168), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "CompanyId",
                keyValue: 2,
                columns: new[] { "ContractEndDate", "ContractStartDate", "CreateDate", "YearOfEstablishment" },
                values: new object[] { new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6177), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6177), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6174), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "CompanyId",
                keyValue: 3,
                columns: new[] { "ContractEndDate", "ContractStartDate", "CreateDate", "YearOfEstablishment" },
                values: new object[] { new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6182), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6182), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6180), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6183) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "CompanyId",
                keyValue: 4,
                columns: new[] { "ContractEndDate", "ContractStartDate", "CreateDate", "YearOfEstablishment" },
                values: new object[] { new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6186), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6186), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6184), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6187) });

            migrationBuilder.UpdateData(
                table: "Companys",
                keyColumn: "CompanyId",
                keyValue: 5,
                columns: new[] { "ContractEndDate", "ContractStartDate", "CreateDate", "YearOfEstablishment" },
                values: new object[] { new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6190), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6189), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6188), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6191) });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6119));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6225));
        }
    }
}
