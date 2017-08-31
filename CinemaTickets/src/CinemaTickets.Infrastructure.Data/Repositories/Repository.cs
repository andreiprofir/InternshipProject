using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using CinemaTickets.Domain.Interfaces;
using CinemaTickets.Infrastructure.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CinemaTickets.Infrastructure.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        private readonly IQuerySpecificationBuilder<TEntity> _queryBuilder;

        public Repository(DbContext context, IQuerySpecificationBuilder<TEntity> queryBuilder)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
            _queryBuilder = queryBuilder;
        }

        public List<TEntity> GetAll()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public TEntity Get(long id)
        {
            return _dbSet.Find(id);
        }

        public List<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }

        public List<TEntity> Find(params ISpecification<TEntity>[] specifications)
        {
            return CreateQuery(specifications).ToList();
        }

        protected IQueryable<TEntity> CreateQuery(ISpecification<TEntity>[] specifications = null)
        {
            if (specifications != null && specifications.Length > 0)
                return _queryBuilder.Build(_dbSet.AsNoTracking(), specifications);

            return _dbSet.AsNoTracking();
        }

        public void Add(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(paramName: nameof(entity));

            _dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(paramName: nameof(entity));

            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(paramName: nameof(entity));

            _dbSet.Remove(entity);
        }

        public void Delete(long id)
        {
            TEntity entity = _dbSet.Find(id);

            if (entity != null)
                _dbSet.Remove(entity);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        #region DisposePattern

        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }

            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}