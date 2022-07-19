using Microsoft.EntityFrameworkCore;
using NZWalks.Modules.Domain;

namespace NZWalks.Data
{
    public class NZWalksDb : DbContext
    {
        public NZWalksDb(DbContextOptions<NZWalksDb> options) : base(options)
        {

        }
        public DbSet<Region>Regions { get; set; }
        public DbSet<walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }

    }
}
