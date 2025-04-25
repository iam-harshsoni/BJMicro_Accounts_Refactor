using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BJMicro_Accounts_Refactor.DataAccess.Data;
using BJMicro_Accounts_Refactor.DataAccess.Repository.IRepository;

namespace BJMicro_Accounts_Refactor.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MicroAccountsContext _db;

        public UnitOfWork(MicroAccountsContext db)
        {
            this._db = db;            
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
