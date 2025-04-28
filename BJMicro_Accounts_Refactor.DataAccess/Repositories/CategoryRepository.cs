using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BJMicro_Accounts_Refactor.DataAccess.Data;
using BJMicro_Accounts_Refactor.DataAccess.Repositories.IRepository;
using BJMicro_Accounts_Refactor.Domain.Entities;

namespace BJMicro_Accounts_Refactor.DataAccess.Repositories
{
    public class CategoryRepository(MicroAccountsContext db) : Repository<TblCategoryMaster>(db), ICategoryRepository
    {

        private readonly MicroAccountsContext _db = db;

        public void Update(TblCategoryMaster entity)
        {
            _db.Update(entity);
        }
    }
}