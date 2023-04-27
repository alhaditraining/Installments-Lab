using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DML.Dtos.PaymentPlan
{
    public class AddPayByIdDto
    {
        public string? UserId { get; set; } = null;
        [Required]
        public Guid Id { get; set; }
        [Required]
        public decimal PaiedAmount { get; set; } 
    }
}
