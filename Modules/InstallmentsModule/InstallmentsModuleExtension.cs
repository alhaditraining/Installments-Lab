using InstallmentsModule.DAL.Database;
using InstallmentsModule.DAL.Service;
using InstallmentsModule.DML.IService;
using Microsoft.EntityFrameworkCore;

namespace InstallmentsModule
{
    public static class InstallmentsModuleExtension
    {
        //public static IServiceCollection AddInstallmentsModule(this IServiceCollection services, IConfiguration configuration)
        //{
        //    services.AddSingleton<ErrorHandlerMiddleware>();

        //    services.AddDbContext<ApplicationDbContext>
        //        (options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
        //        .EnableServiceProviderCaching(false));

        //    services.AddScoped<IAccountService, AccountService>();
        //    services.AddScoped<IPaymentPlanDetailsService, PaymentPlanDetailsService>();
        //    services.AddScoped<IPaymentPlanService, PaymentPlanService>();
        //    services.AddScoped<IInstallmentsUnitOfWork, InstallmentsUnitOfWork>();
        //    return services;
        //}

        //public static IApplicationBuilder UseInstallmentsModule(this IApplicationBuilder app)
        //{

        //    app.UseMiddleware<ErrorHandlerMiddleware>();
        //    using (var serviceScope = app?.ApplicationServices?.GetService<IServiceScopeFactory>()?.CreateScope())
        //    {
        //        var context = serviceScope?.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        //        context?.Database.Migrate();
        //    }
        //    return app;
        //}

        public static IInstallmentsUnitOfWork UseInstallmentsModuleInWindows(string connectionstring)
        {        
            DbContextOptionsBuilder<ApplicationDbContext> options = new DbContextOptionsBuilder<ApplicationDbContext>();
            options.UseSqlServer(connectionstring);

            ApplicationDbContext context = new ApplicationDbContext(options.Options);
            context.Database.Migrate();

            IAccountService accountService = new AccountService(context);
            IPaymentPlanDetailsService paymentPlanDetailsService = new PaymentPlanDetailsService(context);
            IPaymentPlanService paymentPlanService = new PaymentPlanService(context, paymentPlanDetailsService);

            IInstallmentsUnitOfWork unitOfWork = new InstallmentsUnitOfWork(context, accountService, paymentPlanService);
            return unitOfWork;
        }

    }
}
