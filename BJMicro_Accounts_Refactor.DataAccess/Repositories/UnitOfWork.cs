using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BJMicro_Accounts_Refactor.DataAccess.Data;
using BJMicro_Accounts_Refactor.DataAccess.Repositories.IRepository;

namespace BJMicro_Accounts_Refactor.DataAccess.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly MicroAccountsContext _db;
    public DailyRatesRepository DailyRates { get; private set; }
    public CategoryRepository Category { get; private set; }


    public UnitOfWork(MicroAccountsContext db)
    {
        this._db = db;
        DailyRates = new DailyRatesRepository(_db);
        Category = new CategoryRepository(_db);
    }

    public async Task SaveAsync()
    {
        await _db.SaveChangesAsync();
    }
}

