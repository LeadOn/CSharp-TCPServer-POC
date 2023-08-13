﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YuFoot.EntitiesContext.Migrations
{
    /// <inheritdoc />
    public partial class Added_Keycloak_ID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "Player",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 5, 2, 28, 56, 180, DateTimeKind.Local).AddTicks(9513),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 8, 2, 20, 50, 9, 750, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.AddColumn<string>(
                name: "keycloak_id",
                table: "Player",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "played_on",
                table: "GamePlayed",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 5, 2, 28, 56, 180, DateTimeKind.Local).AddTicks(7890),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 8, 2, 20, 50, 9, 750, DateTimeKind.Local).AddTicks(4548));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "keycloak_id",
                table: "Player");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "Player",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 2, 20, 50, 9, 750, DateTimeKind.Local).AddTicks(6291),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 8, 5, 2, 28, 56, 180, DateTimeKind.Local).AddTicks(9513));

            migrationBuilder.AlterColumn<DateTime>(
                name: "played_on",
                table: "GamePlayed",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 8, 2, 20, 50, 9, 750, DateTimeKind.Local).AddTicks(4548),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 8, 5, 2, 28, 56, 180, DateTimeKind.Local).AddTicks(7890));
        }
    }
}