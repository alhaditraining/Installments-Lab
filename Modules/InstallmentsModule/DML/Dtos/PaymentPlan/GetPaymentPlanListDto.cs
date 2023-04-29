using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DML.Dtos.PaymentPlan
{
    public class GetPaymentPlanListDto : Entities.PaymentPlan
    {
        public string AccountName { get; set; }=string.Empty;
    }
}
