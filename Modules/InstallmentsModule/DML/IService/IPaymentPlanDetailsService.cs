using InstallmentsModule.DML.Dtos.PaymentPlanDetails;
using InstallmentsModule.DML.Entities;
using InstallmentsModule.Shared.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DML.IService
{
    public interface IPaymentPlanDetailsService: ICRUDDetailsService<PaymentPlanDetails>
    {
    }
}
