using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SolareWeb.Data.Migrations
{
    public partial class AjusteCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AddressBirths_AddressBirthId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_AddressCurrents_AddressCurrentId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Contacts_ContactId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_AddressBirthId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_AddressCurrentId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ContactId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "AddressBirthId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "AddressCurrentId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Customers");

            migrationBuilder.AddColumn<string>(
                name: "BirthOfState",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthTime",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CityBirth",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Customers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthOfState",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "BirthTime",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CityBirth",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Customers");

            migrationBuilder.AddColumn<int>(
                name: "AddressBirthId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AddressCurrentId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AddressBirths_AddressBirthId",
                table: "Customers",
                column: "AddressBirthId",
                principalTable: "AddressBirths",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_AddressCurrents_AddressCurrentId",
                table: "Customers",
                column: "AddressCurrentId",
                principalTable: "AddressCurrents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Contacts_ContactId",
                table: "Customers",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
