﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samuraj
{
    public class SamuraiContext : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<SecretIdentity> SecretIdentities { get; set; }
        public DbSet<SamuraiBattle> SamuraiBattles { get; set; }
        public DbSet<BattleLog> BattleLogs { get; set; }
        public DbSet<BattleEvent> BattleEvents { get; set; }
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = EfSamurai;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SamuraiBattle>()
                .HasKey(x => new { x.SamuraiId, x.BattleId });
        }   

    }
}
