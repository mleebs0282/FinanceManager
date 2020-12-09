using FM.Application.Interfaces;
using FM.Application.Services;
using FM.Domain.Interfaces;
using FM.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FM.Infrastructure.IoC
{
    public class DependencyAggregate
    {
        public static void RegisterDependencies(IServiceCollection services)
        {
            services.AddScoped<IBillService, BillService>();

            services.AddScoped<IBillRepository, BillRepository>();

            services.AddScoped<IBudgetService, BudgetService>();

            services.AddScoped<IBudgetRepository, BudgetRepository>();
        }
    }
}
