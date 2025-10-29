using MultiShop.Discount.Context;
using MultiShop.Discount.Services;

namespace MultiShop.Discount.Extensions
{
    public static class ServiceRegistrations
    {
        public static void AddDiscount(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddTransient<DapperContext>();
            services.AddTransient<IDiscountService, DiscountService>();
        }
    }
}
