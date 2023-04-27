using InstallmentsModule.DML.Dtos.PaymentPlanDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DML.Dtos.PaymentPlan
{
    public class UpdatePaymentPlanDto
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string AccountId { get; set; } = String.Empty;
        [Required]
        public DateTimeOffset Datetime { get; set; }
        [Required]
        public decimal Amount { get; set; }
        public string? BillTypeId { get; set; } = null;
        public string? BillId { get; set; } = null;
        public string? UserId { get; set; } = null;
        [Required]
        public List<PaymentPlanDetailsDto> PaymentPlanDetails { get; set; } = new List<PaymentPlanDetailsDto>();
    }
}
