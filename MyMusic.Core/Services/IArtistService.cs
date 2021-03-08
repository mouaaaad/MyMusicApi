using MyMusic.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic.Core.Services
{
    public interface IArtistService
    {
        Task<IEnumerable<Artist>> GetAllArtist();
        Task<Music> GetArtistById(int id);
        Task<Artist> CreateArtist(Artist artist);
        Task UpdateArtist(Artist ArtistToBeUpdate, Artist artist);
        Task DeleteArtist(Artist artist);
    }
}
