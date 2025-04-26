using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJMicro_Accounts_Refactor.DataAccess.Repositories.IRepository;
public interface IUnitOfWork
{
    public DailyRatesRepository DailyRates { get; }
    Task SaveAsync();
}

