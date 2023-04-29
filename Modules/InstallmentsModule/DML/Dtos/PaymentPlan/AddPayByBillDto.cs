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
        [MaxLength(50)]
        public string? UserId { get; set; } = null;
        [Required]
        [MaxLength(50)]
        public string BillId { get; set; } = String.Empty;
        [Required]
        [MaxLength(50)]
        public string BillTypeId { get; set; } = String.Empty;
        [Required]
        [MaxLength(50)]
        public decimal PaiedAmount { get; set; }
    }
}
