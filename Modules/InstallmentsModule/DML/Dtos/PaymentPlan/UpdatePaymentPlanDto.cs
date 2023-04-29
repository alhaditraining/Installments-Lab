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
        [MaxLength(50)]
        public string AccountRefId { get; set; } = String.Empty;
        [Required]
        public DateTimeOffset Datetime { get; set; }
        [Required]
        public decimal Amount { get; set; }
        [MaxLength(50)]
        public string? BillTypeId { get; set; } = null;
        [MaxLength(50)]
        public string? BillId { get; set; } = null;
        [MaxLength(50)]
        public string? UserId { get; set; } = null;
        [Required]
        public List<PaymentPlanDetailsDto> PaymentPlanDetails { get; set; } = new List<PaymentPlanDetailsDto>();
    }
}
