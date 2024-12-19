﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameOn.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Added_LoL_Rank_History : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "joined_at",
                table: "TournamentPlayer",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 17, 48, 22, 828, DateTimeKind.Utc).AddTicks(363),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 18, 22, 29, 30, 450, DateTimeKind.Utc).AddTicks(4589));

            migrationBuilder.AlterColumn<DateTime>(
                name: "planned_to",
                table: "Tournament",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 20, 17, 48, 22, 827, DateTimeKind.Utc).AddTicks(7290),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 19, 22, 29, 30, 450, DateTimeKind.Utc).AddTicks(1864));

            migrationBuilder.AlterColumn<DateTime>(
                name: "planned_from",
                table: "Tournament",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 17, 48, 22, 827, DateTimeKind.Utc).AddTicks(7049),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 18, 22, 29, 30, 450, DateTimeKind.Utc).AddTicks(1598));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "Player",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 17, 48, 22, 827, DateTimeKind.Utc).AddTicks(5488),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 18, 22, 29, 30, 449, DateTimeKind.Utc).AddTicks(9982));

            migrationBuilder.AlterColumn<DateTime>(
                name: "played_on",
                table: "FifaGamePlayed",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 18, 48, 22, 828, DateTimeKind.Local).AddTicks(4816),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 18, 23, 29, 30, 450, DateTimeKind.Local).AddTicks(8756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "publication_date",
                table: "Changelog",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 18, 48, 22, 832, DateTimeKind.Local).AddTicks(3577),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 18, 23, 29, 30, 454, DateTimeKind.Local).AddTicks(7345));

            migrationBuilder.CreateTable(
                name: "LeagueOfLegendsRankHistory",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    queue_type = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    tier = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    rank = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    league_points = table.Column<int>(type: "int", nullable: false),
                    wins = table.Column<int>(type: "int", nullable: false),
                    losses = table.Column<int>(type: "int", nullable: false),
                    hot_streak = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    veteran = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    fresh_blood = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    inactive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    created_on = table.Column<DateTime>(type: "datetime(6)", nullable: false, defaultValue: new DateTime(2024, 12, 19, 18, 48, 22, 832, DateTimeKind.Local).AddTicks(4492)),
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeagueOfLegendsRankHistory", x => x.id);
                    table.ForeignKey(
                        name: "FK_Player_LoLRankHistory",
                        column: x => x.PlayerId,
                        principalTable: "Player",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_LeagueOfLegendsRankHistory_PlayerId",
                table: "LeagueOfLegendsRankHistory",
                column: "PlayerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeagueOfLegendsRankHistory");

            migrationBuilder.AlterColumn<DateTime>(
                name: "joined_at",
                table: "TournamentPlayer",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 18, 22, 29, 30, 450, DateTimeKind.Utc).AddTicks(4589),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 19, 17, 48, 22, 828, DateTimeKind.Utc).AddTicks(363));

            migrationBuilder.AlterColumn<DateTime>(
                name: "planned_to",
                table: "Tournament",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 22, 29, 30, 450, DateTimeKind.Utc).AddTicks(1864),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 20, 17, 48, 22, 827, DateTimeKind.Utc).AddTicks(7290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "planned_from",
                table: "Tournament",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 18, 22, 29, 30, 450, DateTimeKind.Utc).AddTicks(1598),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 19, 17, 48, 22, 827, DateTimeKind.Utc).AddTicks(7049));

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_on",
                table: "Player",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 18, 22, 29, 30, 449, DateTimeKind.Utc).AddTicks(9982),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 19, 17, 48, 22, 827, DateTimeKind.Utc).AddTicks(5488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "played_on",
                table: "FifaGamePlayed",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 18, 23, 29, 30, 450, DateTimeKind.Local).AddTicks(8756),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 19, 18, 48, 22, 828, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.AlterColumn<DateTime>(
                name: "publication_date",
                table: "Changelog",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 18, 23, 29, 30, 454, DateTimeKind.Local).AddTicks(7345),
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTime(2024, 12, 19, 18, 48, 22, 832, DateTimeKind.Local).AddTicks(3577));
        }
    }
}
