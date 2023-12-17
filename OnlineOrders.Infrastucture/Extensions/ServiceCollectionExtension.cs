using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrders.Infrastucture.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastucture(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OnlineOrders.Infrastucture.Persistence.OnlineOrdersDbContext>(
               option => option.UseSqlServer(configuration.GetConnectionString("OrdersConnectionString")));
        }
    }
}
