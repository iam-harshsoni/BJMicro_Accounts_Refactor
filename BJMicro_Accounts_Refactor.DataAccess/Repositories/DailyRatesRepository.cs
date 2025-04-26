using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using BJMicro_Accounts_Refactor.DataAccess.Data;
using BJMicro_Accounts_Refactor.DataAccess.Repositories.IRepository;
using BJMicro_Accounts_Refactor.Domain.Entities;

namespace BJMicro_Accounts_Refactor.DataAccess.Repositories
{
    public class DailyRatesRepository : Repository<DailyRate> ,IDailyRatesRepository
    {
        private readonly MicroAccountsContext _db;
        public DailyRatesRepository(MicroAccountsContext db) : base(db)
        {
            this._db = db;
        }

        public void Update(DailyRate dailyRate)
        {
            _db.Update(dailyRate);
        }
    }
}
