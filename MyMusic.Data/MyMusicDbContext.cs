using Microsoft.EntityFrameworkCore;
using MyMusic.Core.Models;
using System;

namespace MyMusic.Data
{
    public class MyMusicDbContext:DbContext
    {
        public MyMusicDbContext(DbContextOptions<MyMusicDbContext> options)
            :base(options)
        {

        }
        public DbSet<Music> Musics { get; set; }
        public DbSet<Artist> artists { get; set; }

    }
}
