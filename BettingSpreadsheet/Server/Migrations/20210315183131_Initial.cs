using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BettingSpreadsheet.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Match = table.Column<string>(type: "TEXT", nullable: false),
                    Selection = table.Column<string>(type: "TEXT", nullable: false),
                    League = table.Column<string>(type: "TEXT", nullable: true),
                    MatchDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    MatchTime = table.Column<TimeSpan>(type: "TEXT", nullable: true),
                    Stake = table.Column<double>(type: "REAL", nullable: false),
                    Odds = table.Column<double>(type: "REAL", nullable: false),
                    ClosingOdds = table.Column<double>(type: "REAL", nullable: false),
                    Tipster = table.Column<string>(type: "TEXT", nullable: true),
                    Bookie = table.Column<string>(type: "TEXT", nullable: true),
                    Sport = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    Locked = table.Column<bool>(type: "INTEGER", nullable: false),
                    BetCreated = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bets",
                columns: new[] { "Id", "BetCreated", "Bookie", "ClosingOdds", "League", "Locked", "Match", "MatchDate", "MatchTime", "Odds", "Selection", "Sport", "Stake", "State", "Tipster" },
                values: new object[] { 1, new DateTime(2021, 3, 15, 19, 31, 30, 510, DateTimeKind.Local).AddTicks(8150), "Norsk-Tipping", 3.25, "Premier League", false, "Manchester City v Arsenal", new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(702905111480), 3.5, "Arsenal -0.5 Asian Handicap", "Football", 2.0, "New", "Benny" });

            migrationBuilder.InsertData(
                table: "Bets",
                columns: new[] { "Id", "BetCreated", "Bookie", "ClosingOdds", "League", "Locked", "Match", "MatchDate", "MatchTime", "Odds", "Selection", "Sport", "Stake", "State", "Tipster" },
                values: new object[] { 2, new DateTime(2021, 3, 15, 19, 31, 30, 511, DateTimeKind.Local).AddTicks(3790), "Pinnacle", 1.8, "Premier League", true, "West Ham v Fulham", new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(702905113790), 1.8400000000000001, "Fulham +0.5 Asian Handicap", "Football", 5.0, "New", "Benny" });

            migrationBuilder.InsertData(
                table: "Bets",
                columns: new[] { "Id", "BetCreated", "Bookie", "ClosingOdds", "League", "Locked", "Match", "MatchDate", "MatchTime", "Odds", "Selection", "Sport", "Stake", "State", "Tipster" },
                values: new object[] { 3, new DateTime(2021, 3, 15, 19, 31, 30, 511, DateTimeKind.Local).AddTicks(3800), "Unibet", 3.25, "Premier League", true, "Liverpool v Leicester", new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(702905113800), 2.75, "Leicester -0.5 Asian Handicap", "Football", 3.2000000000000002, "New", "Sondreg" });

            migrationBuilder.InsertData(
                table: "Bets",
                columns: new[] { "Id", "BetCreated", "Bookie", "ClosingOdds", "League", "Locked", "Match", "MatchDate", "MatchTime", "Odds", "Selection", "Sport", "Stake", "State", "Tipster" },
                values: new object[] { 4, new DateTime(2021, 3, 15, 19, 31, 30, 511, DateTimeKind.Local).AddTicks(3810), "Norsk-Tipping", 3.25, "Premier League", false, "Tottenham v Manchester Untited", new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Local), new TimeSpan(702905113810), 1.5, "Manchester United -0.5 Asian Handicap", "Football", 8.0, "New", "BookieInsider" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bets");
        }
    }
}
