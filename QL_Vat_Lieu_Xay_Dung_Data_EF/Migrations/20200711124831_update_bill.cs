﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QL_Vat_Lieu_Xay_Dung_Data_EF.Migrations
{
    public partial class update_bill : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_AppUsers_CustomerId",
                table: "Bills");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "Bills",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_AppUsers_CustomerId",
                table: "Bills",
                column: "CustomerId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_AppUsers_CustomerId",
                table: "Bills");

            migrationBuilder.AlterColumn<Guid>(
                name: "CustomerId",
                table: "Bills",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_AppUsers_CustomerId",
                table: "Bills",
                column: "CustomerId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
