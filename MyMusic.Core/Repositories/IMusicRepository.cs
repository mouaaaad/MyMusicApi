using MyMusic.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic.Core.Repositories
{
    public interface IMusicRepository:IRepository<Music>
    {
        Task<IEnumerable<Music>> GetAllWithArtistAsync();
        Task<IEnumerable<Music>> GetAllWithArtistByArtistIdAsync(int artistId);
        Task<Music> GetWithArtistByIdAsync(int id);
    }
}
