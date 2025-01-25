﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOn.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Added_LoLGame_Start_End : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "joined_at",
                table: "TournamentPlayer",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 24, 22, 34, 9, 697, DateTimeKind.Utc).AddTicks(7440),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2025, 1, 11, 14, 14, 40, 935, DateTimeKind.Utc).AddTicks(700));

            migrationBuilder.AlterColumn<DateTime>(
                name: "planned_to",
                table: "Tournament",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 25, 22, 34, 9, 693, DateTimeKind.Utc).AddTicks(7020),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2025, 1, 12, 14, 14, 40, 933, DateTimeKind.Utc).AddTicks(380));

            migrationBuilder.AlterColumn<DateTime>(
                name: "planned_from",
                table: "Tournament",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 24, 22, 34, 9, 693, DateTimeKind.Utc).AddTicks(6830),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2025, 1, 11, 14, 14, 40, 933, DateTimeKind.Utc).AddTicks(200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "Player",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 24, 22, 34, 9, 691, DateTimeKind.Utc).AddTicks(8960),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2025, 1, 11, 14, 14, 40, 930, DateTimeKind.Utc).AddTicks(9720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "LeagueOfLegendsRankHistory",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 24, 23, 34, 9, 705, DateTimeKind.Local).AddTicks(9660),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2025, 1, 11, 15, 14, 40, 946, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.AlterColumn<DateTime>(
                name: "retrieved_on",
                table: "LeagueOfLegendsGame",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 24, 23, 34, 9, 706, DateTimeKind.Local).AddTicks(8600),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2025, 1, 11, 15, 14, 40, 947, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.AddColumn<DateTime>(
                name: "game_end",
                table: "LeagueOfLegendsGame",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 24, 23, 34, 9, 706, DateTimeKind.Local).AddTicks(8900));

            migrationBuilder.AddColumn<DateTime>(
                name: "game_start",
                table: "LeagueOfLegendsGame",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 24, 23, 34, 9, 706, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "played_on",
                table: "FifaGamePlayed",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 24, 23, 34, 9, 699, DateTimeKind.Local).AddTicks(6790),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2025, 1, 11, 15, 14, 40, 940, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.AlterColumn<DateTime>(
                name: "publication_date",
                table: "Changelog",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 24, 23, 34, 9, 705, DateTimeKind.Local).AddTicks(3330),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2025, 1, 11, 15, 14, 40, 945, DateTimeKind.Local).AddTicks(8140));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "game_end",
                table: "LeagueOfLegendsGame");

            migrationBuilder.DropColumn(
                name: "game_start",
                table: "LeagueOfLegendsGame");

            migrationBuilder.AlterColumn<DateTime>(
                name: "joined_at",
                table: "TournamentPlayer",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 11, 14, 14, 40, 935, DateTimeKind.Utc).AddTicks(700),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2025, 1, 24, 22, 34, 9, 697, DateTimeKind.Utc).AddTicks(7440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "planned_to",
                table: "Tournament",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 12, 14, 14, 40, 933, DateTimeKind.Utc).AddTicks(380),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2025, 1, 25, 22, 34, 9, 693, DateTimeKind.Utc).AddTicks(7020));

            migrationBuilder.AlterColumn<DateTime>(
                name: "planned_from",
                table: "Tournament",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 11, 14, 14, 40, 933, DateTimeKind.Utc).AddTicks(200),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2025, 1, 24, 22, 34, 9, 693, DateTimeKind.Utc).AddTicks(6830));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "Player",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 11, 14, 14, 40, 930, DateTimeKind.Utc).AddTicks(9720),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2025, 1, 24, 22, 34, 9, 691, DateTimeKind.Utc).AddTicks(8960));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "LeagueOfLegendsRankHistory",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 11, 15, 14, 40, 946, DateTimeKind.Local).AddTicks(4140),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2025, 1, 24, 23, 34, 9, 705, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "retrieved_on",
                table: "LeagueOfLegendsGame",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 11, 15, 14, 40, 947, DateTimeKind.Local).AddTicks(2670),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2025, 1, 24, 23, 34, 9, 706, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "played_on",
                table: "FifaGamePlayed",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 11, 15, 14, 40, 940, DateTimeKind.Local).AddTicks(2810),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2025, 1, 24, 23, 34, 9, 699, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.AlterColumn<DateTime>(
                name: "publication_date",
                table: "Changelog",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2025, 1, 11, 15, 14, 40, 945, DateTimeKind.Local).AddTicks(8140),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2025, 1, 24, 23, 34, 9, 705, DateTimeKind.Local).AddTicks(3330));
        }
    }
}
