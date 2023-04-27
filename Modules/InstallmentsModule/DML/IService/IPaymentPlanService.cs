using InstallmentsModule.DAL.Service;
using InstallmentsModule.DML.Dtos.PaymentPlan;
using InstallmentsModule.DML.Entities;
using InstallmentsModule.Shared.Dtos;
using InstallmentsModule.Shared.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DML.IService
{
    public interface IPaymentPlanService: ICRUDService<PaymentPlan,CreatePaymentPlanDto,UpdatePaymentPlanDto,MainFilterDto>
    {
        public Task<PaymentPlan> GetPaymentPlanByBillAsync(string billId,string billTypeId);
        public Task DeletePaymentPlanByBillAsync(string billId, string billTypeId);
        public Task AddPayByIdAsync(AddPayByIdDto dto);
        public Task AddPayByBillAsync(AddPayByBillDto dto);
    }
}
