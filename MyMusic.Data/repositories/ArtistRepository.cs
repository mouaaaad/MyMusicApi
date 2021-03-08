using Microsoft.EntityFrameworkCore;
using MyMusic.Core.Models;
using MyMusic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic.Data.repositories
{
    class ArtistRepository : Repository<Artist>, IArtistRepository
    {
        private readonly MyMusicDbContext MyMusicDbContext;


        public ArtistRepository(MyMusicDbContext context)
            : base(context)
        {
            MyMusicDbContext = context;
        }

        public async Task<IEnumerable<Artist>> GetAllWithMusicAsync()
        {
            return await MyMusicDbContext.artists.Include(m => m.Musics).ToListAsync();
        }

        public  Task<Artist> GetWithMusicByIdAsync(int id)
        {
            return  MyMusicDbContext.artists.Include(a => a.Musics).SingleOrDefaultAsync(a => a.Id == id);
        }

    }
}
