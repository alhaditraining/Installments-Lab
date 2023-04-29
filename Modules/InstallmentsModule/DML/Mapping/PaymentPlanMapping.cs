using InstallmentsModule.DML.Dtos.PaymentPlan;
using InstallmentsModule.DML.Dtos.PaymentPlanDetails;
using InstallmentsModule.DML.Entities;
using InstallmentsModule.Shared.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule.DML.Mapping
{
    public static class PaymentPlanMapping
    {
        public static PaymentPlan AsEntity(this CreatePaymentPlanDto dto)
        {
            var entity = dto.headerAsEntity();
            detailsAsEntity(entity, dto.PaymentPlanDetails);
            return entity;
        }

        private static PaymentPlan headerAsEntity(this CreatePaymentPlanDto dto)
        {
            var totalAmount = dto.PaymentPlanDetails.Sum(a => a.Amount);
            var entity = new PaymentPlan
            {
                AccountRefId = dto.AccountRefId,
                Id = Guid.NewGuid(),
                Datetime = dto.Datetime,
                TotalAmount = totalAmount,
                BillId = dto.BillId,
                BillTypeId = dto.BillTypeId,
                TotalPaiedAmount = 0,
                TotalRemainingAmount = totalAmount,
                PaymentPlanDetails = new List<PaymentPlanDetails>()
            };
            entity.Create(dto.UserId != null ? dto.UserId : throw new Exception("UserId can not be null value"));
            return entity;
        }

        public static void AsEntity(this UpdatePaymentPlanDto dto, PaymentPlan entity)
        {
            dto.headerAsEntity(entity);
            detailsAsEntity(entity, dto.PaymentPlanDetails);
        }

        private static void headerAsEntity(this UpdatePaymentPlanDto dto, PaymentPlan entity)
        {
            entity.AccountRefId = dto.AccountRefId;
            entity.Datetime = dto.Datetime;
            entity.TotalAmount = dto.Amount;
            entity.BillId = dto.BillId;
            entity.BillTypeId = dto.BillTypeId;
            entity.TotalRemainingAmount = dto.Amount - entity.TotalPaiedAmount;
            entity.PaymentPlanDetails = new List<PaymentPlanDetails>();
            entity.Update(dto.UserId != null ? dto.UserId : throw new Exception("UserId can not be null value"));
        }

        private static void detailsAsEntity(this PaymentPlan entity, List<PaymentPlanDetailsDto> Details)
        {
            decimal paiedamount = entity.TotalPaiedAmount;
            foreach (var item in Details)
            {
                var row = item.AsEntity(paiedamount);
                entity.PaymentPlanDetails.Add(row);
                paiedamount = paiedamount < row.Amount ? 0 : paiedamount - row.Amount;
            }
        }

        public static void AsEntity(this AddPayByIdDto dto, PaymentPlan entity)
        {
            entity.TotalPaiedAmount += dto.PaiedAmount;
            entity.TotalRemainingAmount = entity.TotalAmount - entity.TotalPaiedAmount;
            decimal paiedamount = entity.TotalPaiedAmount;
            foreach (var item in entity.PaymentPlanDetails)
            {
                item.PaiedAmount = paiedamount < item.Amount ? item.Amount - paiedamount : item.Amount;
                item.RemainingAmount = item.Amount - paiedamount;
                paiedamount = paiedamount < item.Amount ? 0 : paiedamount - item.Amount;
            }
        }

        public static void AsEntity(this AddPayByBillDto dto, PaymentPlan entity)
        {
            entity.TotalPaiedAmount += dto.PaiedAmount;
            entity.TotalRemainingAmount = entity.TotalAmount - entity.TotalPaiedAmount;
            decimal paiedamount = entity.TotalPaiedAmount;
            foreach (var item in entity.PaymentPlanDetails)
            {
                item.PaiedAmount = paiedamount < item.Amount ? item.Amount - paiedamount : item.Amount;
                item.RemainingAmount = item.Amount - paiedamount;
                paiedamount = paiedamount < item.Amount ? 0 : paiedamount - item.Amount;
            }
        }
    }
}
