using InstallmentsModule.DAL.Database;
using InstallmentsModule.DML.Dtos.Accounts;
using InstallmentsModule.DML.IService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.Shared.Service
{
    public class Repository<DbContext, Type>
    {
        protected readonly DbContext Context;
        public Repository(DbContext context)
        {
            Context = context;
        }
    }
}
