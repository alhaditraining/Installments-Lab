using InstallmentsModule.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DML.Entities
{
    public class PaymentPlan : MainEntity
    {
        [MaxLength(50)]
        public string AccountRefId { get; set; } = String.Empty;
        public DateTimeOffset Datetime { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal TotalPaiedAmount { get; set; }
        public decimal TotalRemainingAmount { get; set; }
        [MaxLength(50)]
        public string? BillTypeId { get; set; }=null;
        [MaxLength(50)]
        public string? BillId { get; set; }=null ;
        public List<PaymentPlanDetails> PaymentPlanDetails { get; set; } = new List<PaymentPlanDetails>();
    }
}
