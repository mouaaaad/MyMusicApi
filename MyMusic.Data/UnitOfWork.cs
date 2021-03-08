using MyMusic.Core;
using MyMusic.Core.Repositories;
using MyMusic.Data.repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(MyMusicDbContext context)
        {
            this._context = context;
        }
        private readonly MyMusicDbContext _context;
        private IArtistRepository _artistRepository;
        private IMusicRepository _musicsRepository;

        public IMusicRepository Musics => _musicsRepository = _musicsRepository ?? new MusicRepository(_context);
        public IArtistRepository Artists => _artistRepository = _artistRepository ?? new ArtistRepository(_context);
        public void CommitAsync()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
