using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskTarcker.Migrations
{
    public partial class UpdateUserIdColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Assuming you want to update columns in existing tables

            // Update Tasks table
            migrationBuilder.AlterColumn<int>(
                name: "user_id",
                table: "Tasks",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            // If needed, add any new columns or modifications here
            // migrationBuilder.AddColumn<...>(
            //     name: "NewColumnName",
            //     table: "Tasks",
            //     type: "columnType",
            //     nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Reverse the column modification in the Down method

            migrationBuilder.AlterColumn<int>(
                name: "user_id",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: false);

            // Reverse any columns added or modified in Up
            // migrationBuilder.DropColumn(
            //     name: "NewColumnName",
            //     table: "Tasks");
        }
    }
}
