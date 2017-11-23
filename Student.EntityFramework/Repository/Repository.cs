using Student.Core.Entity;
using Student.Core.IRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.EntityFramework.Repository
{
    /// <summary>
    /// Repository Pattern
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        private readonly StudentDBContext _dbContext;

        public Repository(StudentDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbContext.Set<TEntity>().AsNoTracking();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbContext.Set<TEntity>()
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public TEntity GetById(int id)
        {
            return _dbContext.Set<TEntity>()
                .AsNoTracking()
                .FirstOrDefault(e => e.Id == id);
        }

        public async Task Create(TEntity entity)
        {
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
        }

        public async Task Update(int id, TEntity entity)
        {
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.Set<TEntity>().Add(entity);
            _dbContext.SaveChanges();
        }

        public async Task Delete(int id)
        {
            var entity = await _dbContext.Set<TEntity>().FindAsync(id);
            _dbContext.Set<TEntity>().Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
