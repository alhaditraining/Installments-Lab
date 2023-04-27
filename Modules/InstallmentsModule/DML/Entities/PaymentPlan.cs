using InstallmentsModule.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DML.Entities
{
    public class PaymentPlan : MainEntity
    {
        public string AccountId { get; set; } = String.Empty;
        public DateTimeOffset Datetime { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalPaiedAmount { get; set; }
        public decimal TotalRemainingAmount { get; set; }
        public string? BillTypeId { get; set; }=null;
        public string? BillId { get; set; }=null ;
        public List<PaymentPlanDetails> PaymentPlanDetails { get; set; } = new List<PaymentPlanDetails>();
    }
}
