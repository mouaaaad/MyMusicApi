using Microsoft.EntityFrameworkCore;
using MyMusic.Core.Models;
using MyMusic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic.Data.repositories
{
    class MusicRepository : Repository<Music>, IMusicRepository
    {
        private readonly MyMusicDbContext MyMusicDbContext;
  

        public MusicRepository(MyMusicDbContext context)
            :base(context)
        {
            MyMusicDbContext = context;
        }
        public async Task<IEnumerable<Music>> GetAllWithArtistAsync()
        {
            return await MyMusicDbContext.Musics.Include(m => m.Artist).ToListAsync();
        }

        public async Task<IEnumerable<Music>> GetAllWithArtistByArtistIdAsync(int artistId)
        {
            return await MyMusicDbContext.Musics.Include(m => m.Artist).Where(m=>m.ArtistId==artistId).ToListAsync();
        }

        public async Task<Music> GetWithArtistByIdAsync(int id)
        {
            return await MyMusicDbContext.Musics.Include(m => m.Artist).SingleOrDefaultAsync(m => m.Id == id);
        }
    }
}
