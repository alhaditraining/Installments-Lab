using InstallmentsModule.Shared.Dtos;
using InstallmentsModule.Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DML.Entities
{
  
    public class PaymentPlanDetails: MainDetailsEntity
    { 
        public decimal Amount { get; set; }
        public decimal PaiedAmount { get; set; }
        public decimal RemainingAmount { get; set; }
        public DateTimeOffset PaiedDate { get; set; }
    }
}
