﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace YuGames.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Added_Phase2_Challonge_Url : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "joined_at",
                table: "TournamentPlayer",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 17, 19, 46, 740, DateTimeKind.Utc).AddTicks(4990),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 10, 15, 16, 12, 56, 397, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "planned_to",
                table: "Tournament",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 17, 19, 46, 740, DateTimeKind.Utc).AddTicks(4660),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 10, 16, 16, 12, 56, 397, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "planned_from",
                table: "Tournament",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 17, 19, 46, 740, DateTimeKind.Utc).AddTicks(4580),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 10, 15, 16, 12, 56, 397, DateTimeKind.Utc).AddTicks(1210));

            migrationBuilder.AddColumn<string>(
                name: "phase2_challonge_url",
                table: "Tournament",
                type: "TEXT",
                maxLength: 3000,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "Player",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 17, 19, 46, 740, DateTimeKind.Utc).AddTicks(7140),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 10, 15, 16, 12, 56, 397, DateTimeKind.Utc).AddTicks(3950));

            migrationBuilder.AlterColumn<DateTime>(
                name: "played_on",
                table: "FifaGamePlayed",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 19, 19, 46, 740, DateTimeKind.Local).AddTicks(7720),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 10, 15, 18, 12, 56, 397, DateTimeKind.Local).AddTicks(4530));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "phase2_challonge_url",
                table: "Tournament");

            migrationBuilder.AlterColumn<DateTime>(
                name: "joined_at",
                table: "TournamentPlayer",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 16, 12, 56, 397, DateTimeKind.Utc).AddTicks(1670),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 10, 15, 17, 19, 46, 740, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "planned_to",
                table: "Tournament",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 16, 16, 12, 56, 397, DateTimeKind.Utc).AddTicks(1290),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 10, 16, 17, 19, 46, 740, DateTimeKind.Utc).AddTicks(4660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "planned_from",
                table: "Tournament",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 16, 12, 56, 397, DateTimeKind.Utc).AddTicks(1210),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 10, 15, 17, 19, 46, 740, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "Player",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 16, 12, 56, 397, DateTimeKind.Utc).AddTicks(3950),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 10, 15, 17, 19, 46, 740, DateTimeKind.Utc).AddTicks(7140));

            migrationBuilder.AlterColumn<DateTime>(
                name: "played_on",
                table: "FifaGamePlayed",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(2023, 10, 15, 18, 12, 56, 397, DateTimeKind.Local).AddTicks(4530),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldDefaultValue: new DateTime(2023, 10, 15, 19, 19, 46, 740, DateTimeKind.Local).AddTicks(7720));
        }
    }
}
