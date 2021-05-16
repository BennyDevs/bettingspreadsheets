using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BettingSpreadsheet.Server.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipsterId",
                table: "Bets",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Bets",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "BLOB", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "BLOB", nullable: true),
                    Bio = table.Column<string>(type: "TEXT", nullable: true),
                    Public = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bookie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Results = table.Column<double>(type: "REAL", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookie_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sport",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Results = table.Column<double>(type: "REAL", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sport_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tipster",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    BetCount = table.Column<int>(type: "INTEGER", nullable: false),
                    Won = table.Column<int>(type: "INTEGER", nullable: false),
                    Lost = table.Column<int>(type: "INTEGER", nullable: false),
                    AmountStaked = table.Column<double>(type: "REAL", nullable: false),
                    ROI = table.Column<double>(type: "REAL", nullable: false),
                    StartBank = table.Column<double>(type: "REAL", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipster", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tipster_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Bets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BetCreated", "MatchDate", "MatchTime" },
                values: new object[] { new DateTime(2021, 4, 19, 18, 53, 13, 122, DateTimeKind.Local).AddTicks(3340), new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(679931223260) });

            migrationBuilder.UpdateData(
                table: "Bets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BetCreated", "MatchDate", "MatchTime" },
                values: new object[] { new DateTime(2021, 4, 19, 18, 53, 13, 122, DateTimeKind.Local).AddTicks(9420), new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(679931229410) });

            migrationBuilder.UpdateData(
                table: "Bets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BetCreated", "MatchDate", "MatchTime" },
                values: new object[] { new DateTime(2021, 4, 19, 18, 53, 13, 122, DateTimeKind.Local).AddTicks(9440), new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(679931229430) });

            migrationBuilder.UpdateData(
                table: "Bets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BetCreated", "MatchDate", "MatchTime" },
                values: new object[] { new DateTime(2021, 4, 19, 18, 53, 13, 122, DateTimeKind.Local).AddTicks(9440), new DateTime(2021, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(679931229440) });

            migrationBuilder.CreateIndex(
                name: "IX_Bets_TipsterId",
                table: "Bets",
                column: "TipsterId");

            migrationBuilder.CreateIndex(
                name: "IX_Bets_UserId",
                table: "Bets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookie_UserId",
                table: "Bookie",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Sport_UserId",
                table: "Sport",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tipster_UserId",
                table: "Tipster",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bets_Tipster_TipsterId",
                table: "Bets",
                column: "TipsterId",
                principalTable: "Tipster",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Bets_Users_UserId",
                table: "Bets",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bets_Tipster_TipsterId",
                table: "Bets");

            migrationBuilder.DropForeignKey(
                name: "FK_Bets_Users_UserId",
                table: "Bets");

            migrationBuilder.DropTable(
                name: "Bookie");

            migrationBuilder.DropTable(
                name: "Sport");

            migrationBuilder.DropTable(
                name: "Tipster");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Bets_TipsterId",
                table: "Bets");

            migrationBuilder.DropIndex(
                name: "IX_Bets_UserId",
                table: "Bets");

            migrationBuilder.DropColumn(
                name: "TipsterId",
                table: "Bets");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Bets");

            migrationBuilder.UpdateData(
                table: "Bets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BetCreated", "MatchDate", "MatchTime" },
                values: new object[] { new DateTime(2021, 3, 15, 19, 31, 30, 510, DateTimeKind.Local).AddTicks(8150), new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(702905111480) });

            migrationBuilder.UpdateData(
                table: "Bets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BetCreated", "MatchDate", "MatchTime" },
                values: new object[] { new DateTime(2021, 3, 15, 19, 31, 30, 511, DateTimeKind.Local).AddTicks(3790), new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(702905113790) });

            migrationBuilder.UpdateData(
                table: "Bets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BetCreated", "MatchDate", "MatchTime" },
                values: new object[] { new DateTime(2021, 3, 15, 19, 31, 30, 511, DateTimeKind.Local).AddTicks(3800), new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(702905113800) });

            migrationBuilder.UpdateData(
                table: "Bets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BetCreated", "MatchDate", "MatchTime" },
                values: new object[] { new DateTime(2021, 3, 15, 19, 31, 30, 511, DateTimeKind.Local).AddTicks(3810), new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(702905113810) });
        }
    }
}
