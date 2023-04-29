using InstallmentsModule.DAL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DML.IService
{
    public interface IInstallmentsUnitOfWork //: IDisposable
    {
        IAccountService AccountService { get; }
        IPaymentPlanService PaymentPlanService { get; }

        Task SaveChangesAsync();
    }
}
