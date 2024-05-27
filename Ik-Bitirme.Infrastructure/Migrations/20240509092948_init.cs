﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ik_Bitirme.Infrastructure.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Companys",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeesCount = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MersisNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxAdministration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    YearOfEstablishment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContractEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companys", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                    table.ForeignKey(
                        name: "FK_Departments_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BirthPlace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TcIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TerminationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ImageData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    JobId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    Employee_CompanyId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Companys_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companys",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Companys_Employee_CompanyId",
                        column: x => x.Employee_CompanyId,
                        principalTable: "Companys",
                        principalColumn: "CompanyId");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId");
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AdvanceRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Currency = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovalStatus = table.Column<int>(type: "int", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResponseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvanceRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdvanceRequests_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExpenseRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ExpenseType = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Currency = table.Column<int>(type: "int", nullable: false),
                    ApprovalStatus = table.Column<int>(type: "int", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResponseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ImageData = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExpenseRequests_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LeaveType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResponseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NumberOfDays = table.Column<int>(type: "int", nullable: false),
                    ApprovalStatus = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "Admin", "00000000-0000-0000-0000-000000000000", "Admin", "ADMIN" },
                    { "Director", "00000000-0000-0000-0000-000000000000", "Director", "DIRECTOR" },
                    { "Employee", "00000000-0000-0000-0000-000000000000", "Employee", "EMPLOYEE" }
                });

            migrationBuilder.InsertData(
                table: "Companys",
                columns: new[] { "CompanyId", "Address", "ContractEndDate", "ContractStartDate", "CreateDate", "DeleteDate", "Email", "EmployeesCount", "ImageData", "MersisNo", "Name", "PhoneNumber", "Status", "TaxAdministration", "TaxNo", "Title", "UpdateDate", "YearOfEstablishment" },
                values: new object[,]
                {
                    { 1, "Ankara", new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6171), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6170), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6168), null, "abc@company.com", null, null, "123456789", "Firma1", "123456789", 1, "vergiDariresi", "123456789", "ltd", null, new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6173) },
                    { 2, "Ankara", new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6177), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6177), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6174), null, "scd@company.com", null, null, "123456789", "Firma2", "123456789", 1, "vergiDariresi", "123456789", "ltd", null, new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6179) },
                    { 3, "Ankara", new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6182), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6182), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6180), null, "dxs@company.com", null, null, "123456789", "Firma3", "123456789", 1, "vergiDariresi", "123456789", "ltd", null, new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6183) },
                    { 4, "İstanbul", new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6186), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6186), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6184), null, "qwe@company.com", null, null, "123456789", "Firma4", "123456789", 1, "vergiDariresi", "123456789", "ltd", null, new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6187) },
                    { 5, "İstanbul", new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6190), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6189), new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6188), null, "rxa@company.com", null, null, "123456789", "Firma5", "123456789", 1, "vergiDariresi", "123456789", "ltd", null, new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6191) }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "CompanyId", "CreateDate", "DeleteDate", "Name", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6107), null, "Information Technology", 0, null },
                    { 2, null, new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6119), null, "Human Resources", 0, null },
                    { 3, null, new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6121), null, "Accounting", 0, null },
                    { 4, null, new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6122), null, "Marketing", 0, null },
                    { 5, null, new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6123), null, "Sales", 0, null }
                });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "CreateDate", "DeleteDate", "Description", "Name", "Status", "UpdateDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6217), null, "Developing software applications for various platforms.", "Software Developer", 1, null },
                    { 2, new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6220), null, "Analyzing and interpreting complex data sets to provide insights.", "Data Analyst", 1, null },
                    { 3, new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6222), null, "Overseeing project timelines, resources, and deliverables.", "Project Manager", 1, null },
                    { 4, new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6223), null, "Creating and executing marketing campaigns to promote products.", "Marketing Specialist", 1, null },
                    { 5, new DateTime(2024, 5, 9, 12, 29, 47, 136, DateTimeKind.Local).AddTicks(6225), null, "Assisting customers with product inquiries and issue resolution.", "Customer Support Representative", 1, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "BirthPlace", "ConcurrencyStamp", "CreateDate", "DeleteDate", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FirstName", "HireDate", "ImageData", "JobId", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Salary", "SecondLastName", "SecurityStamp", "Status", "TcIdentity", "TerminationDate", "TwoFactorEnabled", "UpdateDate", "UserName" },
                values: new object[] { "1", 0, "abc", new DateTime(2024, 5, 9, 12, 29, 47, 125, DateTimeKind.Local).AddTicks(7894), "aaa", "5e317c6c-7b0f-4e62-950c-752e5fbfb0be", new DateTime(2024, 5, 9, 12, 29, 47, 125, DateTimeKind.Local).AddTicks(7883), null, 1, "AppUser", "admin@example.com", true, "admin", new DateTime(2024, 5, 9, 12, 29, 47, 125, DateTimeKind.Local).AddTicks(7896), null, 1, "admin", false, null, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAEAACcQAAAAELxcE4RhsT6aMVtz65IrlWDSliRE1MQwXTqsqcShABM6H8B8dhaWCfngX26YlciQDg==", "1234567890", false, 123m, null, "d7ec37b9-36e7-40cc-9877-e519c8ea6c5b", 1, "123123", null, false, null, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "BirthPlace", "Employee_CompanyId", "ConcurrencyStamp", "CreateDate", "DeleteDate", "DepartmentId", "Discriminator", "Email", "EmailConfirmed", "FirstName", "HireDate", "ImageData", "JobId", "LastName", "LockoutEnabled", "LockoutEnd", "MiddleName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Salary", "SecondLastName", "SecurityStamp", "Status", "TcIdentity", "TerminationDate", "TwoFactorEnabled", "UpdateDate", "UserName" },
                values: new object[] { "2", 0, "abc", new DateTime(2024, 5, 9, 12, 29, 47, 146, DateTimeKind.Local).AddTicks(2260), "aaa", 1, "e9003fc4-42c8-4944-9da1-8c2fa0fc0625", new DateTime(2024, 5, 9, 12, 29, 47, 146, DateTimeKind.Local).AddTicks(2252), null, 1, "Employee", "ahmet@ahmet.com", true, "sagasg", new DateTime(2024, 5, 9, 12, 29, 47, 146, DateTimeKind.Local).AddTicks(2261), null, 1, "asgsag", false, null, null, "AHMET@EXAMPLE.COM", "AHMET", "AQAAAAEAACcQAAAAEFNnaecIIOFOG5QZw1Te/rAJNkmYWfyuidB2sviuPfXilKVSauMBvV/15Ik0+hnXfQ==", "1234567890", false, 123m, null, "e7b9f979-7e25-4375-8d35-a122f115a31e", 1, "123123", null, false, null, "ahmet" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "Admin", "1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "Employee", "2" });

            migrationBuilder.CreateIndex(
                name: "IX_AdvanceRequests_EmployeeId",
                table: "AdvanceRequests",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DepartmentId",
                table: "AspNetUsers",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Employee_CompanyId",
                table: "AspNetUsers",
                column: "Employee_CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_JobId",
                table: "AspNetUsers",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_CompanyId",
                table: "Departments",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseRequests_EmployeeId",
                table: "ExpenseRequests",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_EmployeeId",
                table: "LeaveRequests",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvanceRequests");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ExpenseRequests");

            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Companys");
        }
    }
}