using InstallmentsModule.DAL.Database;
using InstallmentsModule.DML.IService;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace InstallmentsModule.DAL.Service
{
    public class InstallmentsUnitOfWork : IInstallmentsUnitOfWork
    {
        private readonly ApplicationDbContext Context;

        public IAccountService AccountService { get; }
        public IPaymentPlanService PaymentPlanService { get; }

        //...
        public InstallmentsUnitOfWork(ApplicationDbContext _Context,
                          IAccountService accountService,
                          IPaymentPlanService paymentPlanService)
        {
            Context = _Context;
            AccountService = accountService;
            PaymentPlanService = paymentPlanService;
        }
        public async Task SaveChangesAsync()
        {
            //try
            //{
                await Context.SaveChangesAsync();
            //}
            //catch (DbUpdateException ex)
            //{
            //    var innerException = ex.InnerException as SqlException;
            //    if (innerException?.Number == 2601 || innerException?.Number == 2627)
            //    {
            //        var match = Regex.Match(innerException.Message, @"Duplicate entry '(.*?)' for key '(.+?)'");
            //        var errorMessage = string.Format("The value for {0} already exists in the database.", match.Groups[2].Value);
            //        throw new Exception(errorMessage, ex);
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}
        }
        public void Dispose()
        {
            Context.Dispose();
        }
    }
}