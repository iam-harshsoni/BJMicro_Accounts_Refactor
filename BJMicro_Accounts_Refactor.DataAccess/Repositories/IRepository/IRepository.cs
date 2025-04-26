using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BJMicro_Accounts_Refactor.DataAccess.Repositories.IRepository;

public interface IRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync(string? includeProperties = null);
    Task<T?> GetAsync(Expression<Func<T, bool>> filter, string? includeProperties = null);
    Task AddAsync(T entity);
    void Remove(T entity);
    void RemoveRange(List<T> entities);

    bool Any(Func<T, bool> predicate);
}

