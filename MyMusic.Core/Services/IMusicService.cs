using MyMusic.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic.Core.Services
{
    public interface IMusicService
    {
        Task<IEnumerable<Music>> GetAllWithArtist();
        Task<IEnumerable<Music>> GetMusicByArtist(int artistId);
        Task<Music> GetMusicById(int id);
        Task<Music> CreateMusic(Music music);
        Task UpdateMusic(Music musicToBeUpdate, Music music);
        Task DeleteMusic(Music music);

    }
}
