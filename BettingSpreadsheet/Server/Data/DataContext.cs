using System;
using System.Linq;
using BettingSpreadsheet.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BettingSpreadsheet.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Bet> Bets { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            if (Database.ProviderName == "Microsoft.EntityFrameworkCore.Sqlite")
            {
                // SQLite does not have proper support for DateTimeOffset via Entity Framework Core, see the limitations
                // here: https://docs.microsoft.com/en-us/ef/core/providers/sqlite/limitations#query-limitations
                // To work around this, when the Sqlite database provider is used, all model properties of type DateTimeOffset
                // use the DateTimeOffsetToBinaryConverter
                // Based on: https://github.com/aspnet/EntityFrameworkCore/issues/10784#issuecomment-415769754
                // This only supports millisecond precision, but should be sufficient for most use cases.
                foreach (var entityType in modelBuilder.Model.GetEntityTypes())
                {
                    var properties = entityType.ClrType.GetProperties().Where(p => p.PropertyType == typeof(DateTimeOffset)
                                                                                || p.PropertyType == typeof(DateTimeOffset?));
                    foreach (var property in properties)
                    {
                        modelBuilder
                            .Entity(entityType.Name)
                            .Property(property.Name)
                            .HasConversion(new DateTimeOffsetToBinaryConverter());
                    }
                }
            }

            modelBuilder.Entity<Bet>().HasData(
                new Bet
                {
                    Id = 1,
                    Match = "Manchester City v Arsenal",
                    Selection = "Arsenal -0.5 Asian Handicap",
                    League = "Premier League",
                    Stake = 2,
                    Odds = 3.50,
                    ClosingOdds = 3.25,
                    Tipster = "Benny",
                    Bookie = "Norsk-Tipping",
                    Sport = "Football",
                    State = "New",
                    Locked = false
                },
                new Bet
                {
                    Id = 2,
                    Match = "West Ham v Fulham",
                    Selection = "Fulham +0.5 Asian Handicap",
                    League = "Premier League",
                    Stake = 5,
                    Odds = 1.84,
                    ClosingOdds = 1.8,
                    Tipster = "Benny",
                    Bookie = "Pinnacle",
                    Sport = "Football",
                    State = "New",
                    Locked = true
                },
                new Bet
                {
                    Id = 3,
                    Match = "Liverpool v Leicester",
                    Selection = "Leicester -0.5 Asian Handicap",
                    League = "Premier League",
                    Stake = 3.2,
                    Odds = 2.75,
                    ClosingOdds = 3.25,
                    Tipster = "Sondreg",
                    Bookie = "Unibet",
                    Sport = "Football",
                    State = "New",
                    Locked = true
                },
                new Bet
                {
                    Id = 4,
                    Match = "Tottenham v Manchester Untited",
                    Selection = "Manchester United -0.5 Asian Handicap",
                    League = "Premier League",
                    Stake = 8,
                    Odds = 1.50,
                    ClosingOdds = 3.25,
                    //MatchTime = DateTime.Now.TimeOfDay,
                    Tipster = "BookieInsider",
                    Bookie = "Norsk-Tipping",
                    Sport = "Football",
                    State = "New",
                    Locked = false
                }
            );
        }
    }
}