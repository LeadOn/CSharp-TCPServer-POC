﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOn.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Added_LoLGame_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "joined_at",
                table: "TournamentPlayer",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 27, 14, 20, 50, 81, DateTimeKind.Utc).AddTicks(1902),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 19, 17, 55, 15, 359, DateTimeKind.Utc).AddTicks(8449));

            migrationBuilder.AlterColumn<DateTime>(
                name: "planned_to",
                table: "Tournament",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 28, 14, 20, 50, 80, DateTimeKind.Utc).AddTicks(9425),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 20, 17, 55, 15, 359, DateTimeKind.Utc).AddTicks(5697));

            migrationBuilder.AlterColumn<DateTime>(
                name: "planned_from",
                table: "Tournament",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 27, 14, 20, 50, 80, DateTimeKind.Utc).AddTicks(9241),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 19, 17, 55, 15, 359, DateTimeKind.Utc).AddTicks(5445));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "Player",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 27, 14, 20, 50, 80, DateTimeKind.Utc).AddTicks(7839),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 19, 17, 55, 15, 359, DateTimeKind.Utc).AddTicks(3805));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "LeagueOfLegendsRankHistory",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 27, 15, 20, 50, 86, DateTimeKind.Local).AddTicks(1157),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 19, 18, 55, 15, 364, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "played_on",
                table: "FifaGamePlayed",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 27, 15, 20, 50, 82, DateTimeKind.Local).AddTicks(1328),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 19, 18, 55, 15, 360, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.AlterColumn<DateTime>(
                name: "publication_date",
                table: "Changelog",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 27, 15, 20, 50, 86, DateTimeKind.Local).AddTicks(234),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 19, 18, 55, 15, 364, DateTimeKind.Local).AddTicks(1498));

            migrationBuilder.CreateTable(
                name: "LeagueOfLegendsGame",
                columns: table => new
                {
                    game_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    match_id = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    end_of_game_result = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    game_version = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeagueOfLegendsGame", x => x.game_id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeagueOfLegendsGame");

            migrationBuilder.AlterColumn<DateTime>(
                name: "joined_at",
                table: "TournamentPlayer",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 17, 55, 15, 359, DateTimeKind.Utc).AddTicks(8449),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 27, 14, 20, 50, 81, DateTimeKind.Utc).AddTicks(1902));

            migrationBuilder.AlterColumn<DateTime>(
                name: "planned_to",
                table: "Tournament",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 20, 17, 55, 15, 359, DateTimeKind.Utc).AddTicks(5697),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 28, 14, 20, 50, 80, DateTimeKind.Utc).AddTicks(9425));

            migrationBuilder.AlterColumn<DateTime>(
                name: "planned_from",
                table: "Tournament",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 17, 55, 15, 359, DateTimeKind.Utc).AddTicks(5445),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 27, 14, 20, 50, 80, DateTimeKind.Utc).AddTicks(9241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "Player",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 17, 55, 15, 359, DateTimeKind.Utc).AddTicks(3805),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 27, 14, 20, 50, 80, DateTimeKind.Utc).AddTicks(7839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "LeagueOfLegendsRankHistory",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 18, 55, 15, 364, DateTimeKind.Local).AddTicks(2454),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 27, 15, 20, 50, 86, DateTimeKind.Local).AddTicks(1157));

            migrationBuilder.AlterColumn<DateTime>(
                name: "played_on",
                table: "FifaGamePlayed",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 18, 55, 15, 360, DateTimeKind.Local).AddTicks(2588),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 27, 15, 20, 50, 82, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.AlterColumn<DateTime>(
                name: "publication_date",
                table: "Changelog",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 18, 55, 15, 364, DateTimeKind.Local).AddTicks(1498),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 27, 15, 20, 50, 86, DateTimeKind.Local).AddTicks(234));
        }
    }
}
