using InstallmentsModule.DAL.Database;
using InstallmentsModule.DML.Dtos.Accounts;
using InstallmentsModule.DML.Entities;
using InstallmentsModule.DML.IService;
using InstallmentsModule.DML.Mapping;
using InstallmentsModule.Shared.Dtos;
using InstallmentsModule.Shared.Exceptions;
using InstallmentsModule.Shared.Service;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DAL.Service
{
    public class AccountService :Repository<ApplicationDbContext,Account>, IAccountService
    {
        public AccountService(ApplicationDbContext context) : base(context) { }

        public async Task<Guid> CreateAsync(CreateAccountDto dto)
        {
            var entity = dto.AsEntity();
            await Context.Accounts.AddAsync(entity);
            return entity.Id;
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
        public async Task DeleteByRefId(string refId)
        {
            var entity = await GetByRefId(refId);
            Context.Remove(entity);
        }
        public async Task<Account> GetAsync(Guid id)
        {
            var entity = await Context.Accounts.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (entity != null)
                return entity;
            throw new CustomException("هذا الحساب غير موجود");
        }

        private async Task<Account> GetByRefId(string refId)
        {
            var entity = await Context.Accounts.Where(x=>x.RefId==refId).FirstOrDefaultAsync();
            if (entity != null)
                return entity;
            throw new CustomException("هذا الحساب غير موجود");
        }

        public Task<List<Account>> GetListAsync(MainFilterDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(UpdateAccountDto dto)
        {
            var entity = await GetByRefId(dto.RefId);
            dto.AsEntity(entity);
        }
    }
}
