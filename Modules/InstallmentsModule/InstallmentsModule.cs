using InstallmentsModule.DAL.Database;
using InstallmentsModule.DAL.Service;
using InstallmentsModule.DML.IService;
using InstallmentsModule.Shared.Exceptions;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstallmentsModule
{
    public static class InstallmentsModule
    {
        public static IServiceCollection AddInstallmentsModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<ErrorHandlerMiddleware>();

            services.AddDbContext<ApplicationDbContext>
                (options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
                .EnableServiceProviderCaching(false));

            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IPaymentPlanDetailsService, PaymentPlanDetailsService>();
            services.AddScoped<IPaymentPlanService, PaymentPlanService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }

        public static IApplicationBuilder UseInstallmentsModule(this IApplicationBuilder app)
        {

            app.UseMiddleware<ErrorHandlerMiddleware>();
            using (var serviceScope = app?.ApplicationServices?.GetService<IServiceScopeFactory>()?.CreateScope())
            {
                var context = serviceScope?.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                context?.Database.Migrate();
            }
            return 
                app;
        }
    }
}
