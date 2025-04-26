using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BJMicro_Accounts_Refactor.DataAccess.Data;
using BJMicro_Accounts_Refactor.DataAccess.Repositories.IRepository;
using Microsoft.EntityFrameworkCore;

namespace BJMicro_Accounts_Refactor.DataAccess.Repositories;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly MicroAccountsContext _db;
    internal DbSet<T> dbSet;
    public Repository(MicroAccountsContext db)
    {
        this._db = db;
        dbSet = _db.Set<T>();
    }

    public async Task AddAsync(T entity)
    {
        await dbSet.AddAsync(entity);
    }

    public async Task<T?> GetAsync(Expression<Func<T, bool>> filter, string? includeProperties = null)
    {
        IQueryable<T> query = dbSet;
        query = query.Where(filter);

        if (!string.IsNullOrEmpty(includeProperties))
        {
            foreach (var includProp in includeProperties
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includProp);
            }
        }

        return await query.FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync(string? includeProperties = null)
    {
        IQueryable<T> query = dbSet;

        if (!string.IsNullOrEmpty(includeProperties))
        {
            foreach (var property in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(property);
            }
        }

        return await query.ToListAsync();
    }

    public void Remove(T entity)
    {
        dbSet.Remove(entity);
    }

    public void RemoveRange(List<T> entities)
    {
        dbSet.RemoveRange(entities);
    }

    public bool Any(Func<T, bool> predicate)
    {
        return dbSet.Any(predicate);
    }
}

