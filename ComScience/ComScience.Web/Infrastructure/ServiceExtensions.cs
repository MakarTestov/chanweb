using ComScience.Web.Data;

namespace ComScience.Web.Infrastructure
{
    public static class ServiceExtensions
    {
        public static void ConfigureSingletonServices(this IServiceCollection services)
        {
            var storage = new StorageData();
            services.AddSingleton(storage);
        }
    }
}
