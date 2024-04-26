using Microsoft.Extensions.DependencyInjection;
using Microsoft.FluentUI.AspNetCore.Components;

namespace BlazorHybrid.View
{
    public static class Initializer
    {
        public static void Initialize(IServiceCollection services)
        {
            services.AddFluentUIComponents();
        }
    }
}