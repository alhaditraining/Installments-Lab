using InstallmentsModule.DML.Dtos.Accounts;
using InstallmentsModule.DML.Entities;
using InstallmentsModule.Shared.Dtos;
using InstallmentsModule.Shared.IService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DML.IService
{
    public interface IAccountService: ICRUDService<Account, CreateAccountDto, UpdateAccountDto,Account,MainFilterDto>
    {
        public Task DeleteByRefId(string refId);
    }
}
