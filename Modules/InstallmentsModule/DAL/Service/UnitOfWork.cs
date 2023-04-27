using InstallmentsModule.DAL.Database;
using InstallmentsModule.DML.IService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DAL.Service
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext Context;

        public IAccountService AccountService { get; }

        public IPaymentPlanDetailsService PaymentPlanDetailsService { get; }

        public IPaymentPlanService PaymentPlanService { get; }

        //...
        public UnitOfWork(ApplicationDbContext _Context,
                          IAccountService accountService,
                          IPaymentPlanDetailsService paymentPlanDetailsService,
                          IPaymentPlanService paymentPlanService)
        {
            Context = _Context;
            AccountService = accountService;
            PaymentPlanDetailsService = paymentPlanDetailsService;
            PaymentPlanService = paymentPlanService;
        }
        public async Task SaveChangesAsync()
        {
           await Context.SaveChangesAsync();
        }
        public void Dispose()
        {
            Context.Dispose();
        }
    }
}