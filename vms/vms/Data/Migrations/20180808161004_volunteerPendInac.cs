using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace vms.Data.Migrations
{
    public partial class volunteerPendInac : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumbers",
                table: "Volunteers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "EmerPhoneNum",
                table: "Volunteers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<bool>(
                name: "IsInactive",
                table: "Volunteers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPending",
                table: "Volunteers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInactive",
                table: "Volunteers");

            migrationBuilder.DropColumn(
                name: "IsPending",
                table: "Volunteers");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumbers",
                table: "Volunteers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EmerPhoneNum",
                table: "Volunteers",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
