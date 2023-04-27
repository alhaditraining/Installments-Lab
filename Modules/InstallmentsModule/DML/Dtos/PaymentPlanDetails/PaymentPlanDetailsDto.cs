using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DML.Dtos.PaymentPlanDetails
{
    public class PaymentPlanDetailsDto
    {
        public Guid? HeaderId { get; set; }
        [Required]
        [Range(minimum: 0, maximum: 999999999999)]
        public decimal Amount { get; set; }
        [Required]
        public DateTimeOffset PaiedDate { get; set; }
    }
}
