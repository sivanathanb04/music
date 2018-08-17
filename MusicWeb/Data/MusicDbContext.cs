using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicWeb.Entities;
using Microsoft.EntityFrameworkCore;

namespace MusicWeb.Data
{
    public class MusicDbContext:DbContext
    {
        public DbSet<Music> Musics { get; set; }

        public MusicDbContext(DbContextOptions<MusicDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
