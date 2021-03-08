using Microsoft.EntityFrameworkCore;
using MyMusic.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyMusic.Data.repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _context;
        public Repository(DbContext context)
        {
            this._context = context;
        }
        public async Task AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            //_context.SaveChanges();
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _context.Set<TEntity>().AddRangeAsync(entities);
        }

        public  IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return  _context.Set<TEntity>().Where(predicate);
        }

        public async Task<IEnumerable<TEntity>> getAllAsync(int id)
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async ValueTask<TEntity> getByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
        }

        public  Task<TEntity> SingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return  _context.Set<TEntity>().SingleOrDefaultAsync(predicate);
        }
    }
}
