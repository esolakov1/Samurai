using System;
using Microsoft.EntityFrameworkCore;
using SamutaiApp.Domain;

namespace SamuraiApp.Data
{
    public class SamuraiDbContext: DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Clan> Clans { get; set; }
        
    }
}
