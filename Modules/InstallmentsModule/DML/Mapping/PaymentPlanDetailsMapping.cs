using InstallmentsModule.DML.Dtos.PaymentPlanDetails;
using InstallmentsModule.DML.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DML.Mapping
{
    public static class PaymentPlanDetailsMapping
    {
        public static PaymentPlanDetails AsEntity(this PaymentPlanDetailsDto dto,decimal TotelPaiedAmount)
        {
            decimal paiedamount = TotelPaiedAmount < dto.Amount ? dto.Amount - TotelPaiedAmount : dto.Amount;
            decimal remainingamont = dto.Amount - paiedamount;
            return new PaymentPlanDetails
            {
                Id = Guid.NewGuid(),
                HeaderId = dto.HeaderId != null ? (Guid)dto.HeaderId : throw new Exception("HeaderId can not be null value"),
                Amount = dto.Amount,
                PaiedDate = dto.PaiedDate,
                PaiedAmount = paiedamount,
                RemainingAmount = remainingamont,
            };
        }
    }
}
