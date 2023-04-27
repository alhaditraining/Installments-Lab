using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DML.Dtos.PaymentPlan
{
    public class AddPayByBillDto
    {
        public string? UserId { get; set; } = null;
        [Required]
        public string BillId { get; set; } = String.Empty;
        [Required]
        public string BillTypeId { get; set; } = String.Empty;
        [Required]
        public decimal PaiedAmount { get; set; }
    }
}
