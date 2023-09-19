﻿// <auto-generated />

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YuGames.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Trying_To_Fix_Issues_With_IsPlayed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "joined_at",
                table: "TournamentPlayer",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 18, 45, 4, 852, DateTimeKind.Utc).AddTicks(6548),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 9, 18, 9, 27, 10, 986, DateTimeKind.Utc).AddTicks(1510));

            migrationBuilder.AlterColumn<DateTime>(
                name: "planned_to",
                table: "Tournament",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 19, 18, 45, 4, 852, DateTimeKind.Utc).AddTicks(5985),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 9, 19, 9, 27, 10, 986, DateTimeKind.Utc).AddTicks(1180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "planned_from",
                table: "Tournament",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 18, 45, 4, 852, DateTimeKind.Utc).AddTicks(5875),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 9, 18, 9, 27, 10, 986, DateTimeKind.Utc).AddTicks(1080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "Player",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 18, 45, 4, 853, DateTimeKind.Utc).AddTicks(204),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 9, 18, 9, 27, 10, 986, DateTimeKind.Utc).AddTicks(3770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "played_on",
                table: "FifaGamePlayed",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 20, 45, 4, 853, DateTimeKind.Local).AddTicks(1054),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 9, 18, 11, 27, 10, 986, DateTimeKind.Local).AddTicks(4300));

            migrationBuilder.AlterColumn<bool>(
                name: "is_played",
                table: "FifaGamePlayed",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "INTEGER",
                oldDefaultValue: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "joined_at",
                table: "TournamentPlayer",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 9, 27, 10, 986, DateTimeKind.Utc).AddTicks(1510),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 9, 18, 18, 45, 4, 852, DateTimeKind.Utc).AddTicks(6548));

            migrationBuilder.AlterColumn<DateTime>(
                name: "planned_to",
                table: "Tournament",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 19, 9, 27, 10, 986, DateTimeKind.Utc).AddTicks(1180),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 9, 19, 18, 45, 4, 852, DateTimeKind.Utc).AddTicks(5985));

            migrationBuilder.AlterColumn<DateTime>(
                name: "planned_from",
                table: "Tournament",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 9, 27, 10, 986, DateTimeKind.Utc).AddTicks(1080),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 9, 18, 18, 45, 4, 852, DateTimeKind.Utc).AddTicks(5875));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "Player",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 9, 27, 10, 986, DateTimeKind.Utc).AddTicks(3770),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 9, 18, 18, 45, 4, 853, DateTimeKind.Utc).AddTicks(204));

            migrationBuilder.AlterColumn<DateTime>(
                name: "played_on",
                table: "FifaGamePlayed",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 18, 11, 27, 10, 986, DateTimeKind.Local).AddTicks(4300),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 9, 18, 20, 45, 4, 853, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.AlterColumn<bool>(
                name: "is_played",
                table: "FifaGamePlayed",
                type: "INTEGER",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "INTEGER");
        }
    }
}
