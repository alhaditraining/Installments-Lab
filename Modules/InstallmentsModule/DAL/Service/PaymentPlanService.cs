﻿using InstallmentsModule.DAL.Database;
using InstallmentsModule.DML.Dtos.PaymentPlan;
using InstallmentsModule.DML.Entities;
using InstallmentsModule.DML.IService;
using InstallmentsModule.DML.Mapping;
using InstallmentsModule.Shared.Dtos;
using InstallmentsModule.Shared.Exceptions;
using InstallmentsModule.Shared.Service;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace InstallmentsModule.DAL.Service
{
    public class PaymentPlanService :  Repository<ApplicationDbContext,PaymentPlan>,IPaymentPlanService
    {
        IPaymentPlanDetailsService PaymentPlanDetailsService;
        public PaymentPlanService(ApplicationDbContext context, IPaymentPlanDetailsService paymentPlanDetailsService) : base(context) 
        {
            PaymentPlanDetailsService = paymentPlanDetailsService;
        }

        public async Task AddPayByBillAsync(AddPayByBillDto dto)
        {
           
            var entity = await GetPaymentPlanByBillAsync(dto.BillId,dto.BillTypeId);
            addPayValidation(entity, dto.PaiedAmount);
            dto.AsEntity(entity);
        }
        private void addPayValidation(PaymentPlan entity, decimal paiedAmount)
        {
            if (entity.TotalPaiedAmount + paiedAmount > entity.TotalAmount)
                throw new CustomException("المبلغ المدفوع اكثر من المبلغ الكلي");

            if (entity.TotalPaiedAmount + paiedAmount < 0)
                throw new CustomException("لا يمكن للمبلغ المدفوع ان يكون اقل من صفر");
        }
        public async Task AddPayByIdAsync(AddPayByIdDto dto)
        {
            var entity = await GetAsync(dto.Id);
            addPayValidation(entity, dto.PaiedAmount);
            dto.AsEntity(entity);
            await PaymentPlanDetailsService.UpdateAsync(dto.Id, entity.PaymentPlanDetails);
        }

        public async Task<Guid> CreateAsync(CreatePaymentPlanDto dto)
        {
            var entity = dto.AsEntity();
            totelAmountValidation(entity.TotalAmount);
            await Context.PaymentPlan.AddAsync(entity);
            await PaymentPlanDetailsService.CreateAsync(entity.PaymentPlanDetails);
            return entity.Id;
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await GetAsync(id);
            deleteValidation(entity);
            Context.PaymentPlan.Remove(entity);
            await PaymentPlanDetailsService.DeleteByHeaderIdAsync(id);
        }
        private void deleteValidation(PaymentPlan entity)
        {
            if (entity.TotalPaiedAmount > 0)
                throw new CustomException("لا يمكن مسح قسط مدفوع جزئي او كلي");
        }
        public async Task DeletePaymentPlanByBillAsync(string billId, string billTypeId)
        {
            var entity = await GetPaymentPlanByBillAsync(billId, billTypeId);
            deleteValidation(entity);
            Context.PaymentPlan.Remove(entity);
            await PaymentPlanDetailsService.DeleteByHeaderIdAsync(entity.Id);
        }

        public async Task<PaymentPlan> GetAsync(Guid id)
        {
            var entity = await Context.PaymentPlan.Where(a=>a.Id==id).FirstOrDefaultAsync();
            if (entity != null)
            {
                entity.PaymentPlanDetails = await PaymentPlanDetailsService.GetByHeaderIdAsync(id);
                return entity;
            }
            throw new CustomException("هذا القسط غير موجود");
        }

        public Task<List<PaymentPlan>> GetListAsync(MainFilterDto dto)
        {
            throw new NotImplementedException();
        }

        public async Task<PaymentPlan> GetPaymentPlanByBillAsync(string billId, string billTypeId)
        {
            var entity = await Context.PaymentPlan.Where(a => a.BillId == billId && a.BillTypeId == billTypeId).FirstOrDefaultAsync();
            if (entity != null)
            {
                entity.PaymentPlanDetails = await PaymentPlanDetailsService.GetByHeaderIdAsync(entity.Id);
                return entity;
            }
            throw new CustomException("هذا القسط غير موجود");
        }

        public async Task UpdateAsync(UpdatePaymentPlanDto dto)
        {
            var entity = await GetAsync(dto.Id);
            updateValidation(dto, entity);
            dto.AsEntity(entity);
            totelAmountValidation(entity.TotalAmount);
            await PaymentPlanDetailsService.UpdateAsync(dto.Id , entity.PaymentPlanDetails);
        }
        private void updateValidation(UpdatePaymentPlanDto dto,PaymentPlan entity)
        {
            if (entity.TotalPaiedAmount > dto.Amount)
                throw new CustomException("لا يمكن ان يكون المبلغ اقل من المبلغ المدفوع");
        }
        private void totelAmountValidation(decimal totalAmount)
        {
            if (totalAmount < 1)
                throw new CustomException("يجب ان يكون مجموع المبلغ اكبر من صفر");
        }

    }
}
