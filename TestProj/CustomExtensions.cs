using TestProj.Builders;
using TestProj.Builders.Interfaces;
using TestProj.Handlers;
using TestProj.Handlers.Interfaces;
using TestProj.ServiceInterfaces;
using TestProj.Services;

namespace TestProj
{
    public static class CustomExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IListifyHandler, ListifyHandler>();
            services.AddScoped<IListifyResourceBuilder, ListifyResourceBuilder>();
            services.AddScoped<IListifyService, ListifyService>();
            return services;
        }
    }
}
