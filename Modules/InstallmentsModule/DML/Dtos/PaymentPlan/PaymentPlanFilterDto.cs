using InstallmentsModule.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DML.Dtos.PaymentPlan
{
    public class PaymentPlanFilterDto:MainFilterDto
    {
        [MaxLength(50)]
        public string? AccountId { get; set; } = String.Empty;
        public DateTimeOffset? FromDatetime { get; set; }
        public DateTimeOffset? ToDatetime { get; set; }
    }
}
