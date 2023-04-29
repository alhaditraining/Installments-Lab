using InstallmentsModule.DML.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace InstallmentsModule.DAL.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<PaymentPlanDetails> PaymentPlanDetails { get; set; }
        public DbSet<PaymentPlan> PaymentPlan { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("InstallmentsModule");


            //PaymentPlan 
            modelBuilder.Entity<PaymentPlan>().HasIndex(e => new { e.BillId, e.BillTypeId }).HasFilter("BillId IS NOT NULL and BillTypeId IS NOT NULL").IsUnique();
            modelBuilder.Entity<PaymentPlan>().HasIndex(e => new { e.AccountRefId });
            modelBuilder.Entity<PaymentPlan>().HasIndex(e => new { e.Datetime });
            modelBuilder.Entity<PaymentPlan>().HasIndex(e => new { e.CreatedByUserId });
            modelBuilder.Entity<PaymentPlan>().HasIndex(e => new { e.LastUpdateByUserId });
            modelBuilder.Entity<PaymentPlan>().HasIndex(e => new { e.CreatedDatetime });
            modelBuilder.Entity<PaymentPlan>().HasIndex(e => new { e.LastUpdateDatetime });

            //Account 
            modelBuilder.Entity<Account>().HasIndex(e => new { e.CreatedByUserId });
            modelBuilder.Entity<Account>().HasIndex(e => new { e.LastUpdateByUserId });
            modelBuilder.Entity<Account>().HasIndex(e => new { e.CreatedDatetime });
            modelBuilder.Entity<Account>().HasIndex(e => new { e.LastUpdateDatetime });
        }
    }
}
