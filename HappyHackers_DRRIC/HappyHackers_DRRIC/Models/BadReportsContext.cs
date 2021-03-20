using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HappyHackers_DRRIC.Models
{
    public class BadReportsContext : DbContext
    {
        public BadReportsContext(DbContextOptions<BadReportsContext> options)
            :base(options)
        {
        }

        public DbSet<BadReports> BadReport { get; set; }
        public DbSet<Cryptocurrency> Cryptocurrencys { get; set; }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<PostingLicensee> PostingLicensees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostingLicensee>().HasData(
                new PostingLicensee { LicenseeID = "Coin01", LicenseeName = "Coinbase" },
                new PostingLicensee { LicenseeID = "Gem02", LicenseeName = "Gemini" },
                new PostingLicensee { LicenseeID = "Pax03", LicenseeName = "Paxos" }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = "CE1", Crime = "Child Explotation" },
                new Category { CategoryID = "HT1", Crime = "Human Tracking" },
                new Category { CategoryID = "TF1", Crime = "Terror Financing" }
                );
            
            modelBuilder.Entity<Cryptocurrency>().HasData(
                new Cryptocurrency { CurrencyID = "E1", Code = "ETH" },
                new Cryptocurrency { CurrencyID = "X2", Code = "XRP" },
                new Cryptocurrency { CurrencyID = "B3", Code = "BTC" }
                );
                                    
            modelBuilder.Entity<BadReports>().HasData(
                new BadReports
                {
                    uid = "113177321",
                    CoinAddress = "rwU8rAiE2eyEPz3sikfbHuqCuiAtdXqa2v",
                    Hash = "i9zzz3zz0m37mzi90704330990mz99443b2z03b7z7220073bi49b7m0z347b923",
                    FirstName = "Zac",
                    LastName = "Wellmer",
                    DOB = "10/17/1994",
                    IPAddress = "192.0.7.8",
                    CurrencyID = "X2",
                    LicenseeID = "Coin01"
                },
                 new BadReports
                 {
                     uid = "107672511",
                     CoinAddress = "r3mZvvHVLPtRWAujzBsAoXqH11jhwQZvzY",
                     Hash = "24ii22zz44432i9260b26960i393b69007z6z737b0224074z209940399zz9973",
                     FirstName = "Anabel",
                     LastName = "Asare",
                     DOB = "3/2/1971",
                     IPAddress = "192.0.6.1",
                     CurrencyID = "X2",
                     LicenseeID = "Gem02"
                 },
                  new BadReports
                  {
                      uid = "106820062",
                      CoinAddress = "rNwgkFj6QadEXUyS1jgTD2XEsi8HanKzDX",
                      Hash = "00063zmmz667293973327002i7307779707mb977b0i9z9b4ib3bz77mb33zm3i3",
                      FirstName = "Jess",
                      LastName = "Mann",
                      DOB = "9/4/1974",
                      IPAddress = "192.0.2.1",
                      CurrencyID = "X2",
                      LicenseeID = "Pax03"
                  }
                );
        }
    }
}
