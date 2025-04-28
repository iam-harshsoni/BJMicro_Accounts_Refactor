using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BJMicro_Accounts_Refactor.Domain.Entities;

namespace BJMicro_Accounts_Refactor.DataAccess.Repositories.IRepository
{
    public interface ICategoryRepository : IRepository<TblCategoryMaster>
    {
        void Update(TblCategoryMaster entity);
    }
}