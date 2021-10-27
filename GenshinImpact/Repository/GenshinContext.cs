using GenshinImpact.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Reflection;
using System.Globalization;

namespace GenshinImpact.Repository
{
    public class GenshinContext : DbContext
    {
        public GenshinContext(DbContextOptions<GenshinContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Artifacts> Artifacts { get; set; }
        public DbSet<Characters> Characters { get; set; }
        public DbSet<Constellations> Constellations { get; set; }
        public DbSet<ConsumablesFood> ConsumablesFoods { get; set; }
        public DbSet<ConsumablesPotions> ConsumablesPotions { get; set; }
        public DbSet<Details> Details { get; set; }
        public DbSet<Domains> Domains { get; set; }
        public DbSet<Drops> Drops { get; set; }
        public DbSet<Elemental> Elemental { get; set; }
        public DbSet<Elements> Elements { get; set; }
        public DbSet<Enemies> Enemies { get; set; }
        public DbSet<Materials> Materials { get; set; }
        public DbSet<Nations> Nations { get; set; }
        public DbSet<PassiveTalents> PassiveTalents { get; set; }
        public DbSet<Reactions> Reactions { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Requirements> Requirements { get; set; }
        public DbSet<Rewards> Rewards { get; set; }
        public DbSet<SkillTalents> SkillTalents { get; set; }
        public DbSet<Weapons> Weapons { get; set; }
    }
}