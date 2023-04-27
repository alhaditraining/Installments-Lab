using InstallmentsModule.DAL.Database;
using InstallmentsModule.DML.Dtos.PaymentPlanDetails;
using InstallmentsModule.DML.Entities;
using InstallmentsModule.DML.IService;
using InstallmentsModule.DML.Mapping;
using InstallmentsModule.Shared.Dtos;
using InstallmentsModule.Shared.IService;
using InstallmentsModule.Shared.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DAL.Service
{
    public class PaymentPlanDetailsService :Repository<ApplicationDbContext,PaymentPlanDetails>, IPaymentPlanDetailsService
    {
        public PaymentPlanDetailsService(ApplicationDbContext context) : base(context){}

        public async Task CreateAsync(List<PaymentPlanDetails> entities)
        {
            await Context.PaymentPlanDetails.AddRangeAsync(entities);
        }

        public async Task DeleteByHeaderIdAsync(Guid headerId)
        {
            var list = await GetByHeaderIdAsync(headerId);
            Context.PaymentPlanDetails.RemoveRange(list);
        }

        public async Task<List<PaymentPlanDetails>> GetByHeaderIdAsync(Guid headerId)
        {
            var list = await Context.PaymentPlanDetails.Where(a => a.HeaderId == headerId).ToListAsync();
            return list;
        }

        public async Task UpdateAsync(Guid headerId,List<PaymentPlanDetails> entities)
        {
            await DeleteByHeaderIdAsync(headerId);
            await CreateAsync(entities);
        }
    }
}
