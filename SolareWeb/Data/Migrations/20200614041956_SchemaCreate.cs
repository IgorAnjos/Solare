using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SolareWeb.Data.Migrations
{
    public partial class SchemaCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressBirths",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfBirth = table.Column<string>(nullable: true),
                    BirthTime = table.Column<string>(nullable: true),
                    CityBirth = table.Column<string>(nullable: true),
                    BirthOfState = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressBirths", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AddressCurrents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Complement = table.Column<string>(nullable: true),
                    CEP = table.Column<string>(nullable: true),
                    Neighborhoods = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressCurrents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    AddressBirthId = table.Column<int>(nullable: true),
                    ContactId = table.Column<int>(nullable: true),
                    AddressCurrentId = table.Column<int>(nullable: true),
                    Enable = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ModifieldBy = table.Column<int>(nullable: false),
                    ModifieldOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_AddressBirths_AddressBirthId",
                        column: x => x.AddressBirthId,
                        principalTable: "AddressBirths",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_AddressCurrents_AddressCurrentId",
                        column: x => x.AddressCurrentId,
                        principalTable: "AddressCurrents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Customers_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AddressBirthId",
                table: "Customers",
                column: "AddressBirthId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AddressCurrentId",
                table: "Customers",
                column: "AddressCurrentId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ContactId",
                table: "Customers",
                column: "ContactId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "AddressBirths");

            migrationBuilder.DropTable(
                name: "AddressCurrents");

            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
