using InstallmentsModule.DML.Dtos.Accounts;
using InstallmentsModule.DML.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DML.Mapping
{
    public static class AccountsMapping
    {
        public static Account AsEntity(this CreateAccountDto dto)
        {
            var entity = new Account
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                RefId = dto.RefId
            };
            entity.Create(dto.UserId != null ? dto.UserId : throw new Exception("UserId can not be null value"));
            return entity;
        }

        public static void AsEntity(this UpdateAccountDto dto,Account entity)
        {
            entity.Name = dto.Name;
            entity.Update(dto.UserId != null ? dto.UserId : throw new Exception("UserId can not be null value"));
        }

    }
}
