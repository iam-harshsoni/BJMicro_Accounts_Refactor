using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BJMicro_Accounts_Refactor.DataAccess.Data;
using BJMicro_Accounts_Refactor.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace BJMicro_Accounts_Refactor.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly MicroAccountsContext _db;
        internal DbSet<T> dbset;
        public Repository(MicroAccountsContext db)
        {
            this._db = db;
            dbset = _db.Set<T>();
        }

        public void Add(T entity)
        {
            dbset.Add(entity);
        }

        public T Get(Expression<Func<T, bool>> filter, string? includeProperties = null)
        {
            IQueryable<T> query = dbset;
            query = query.Where(filter);

            if (!String.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll(string? includeProperties = null)
        {
            IQueryable<T> query = dbset;

            if (!String.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            return query.ToList();
        }

        public void Remove(T entity)
        {
            dbset.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            dbset.RemoveRange(entities);
        }

        public bool Any(Func<T, bool> predicate)
        {
            return dbset.Any(predicate);
        }
    }
}
