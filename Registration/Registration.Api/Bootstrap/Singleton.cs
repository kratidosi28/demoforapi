using Microsoft.Extensions.DependencyInjection;
using Registration.Infrastructure.Singleton;
using Registration.BoundedContext.Singleton;
using RxWeb.Core.Data;

namespace Registration.Api.Bootstrap
{
    public static class Singleton
    {
        public static void AddSingletonService(this IServiceCollection serviceCollection)
        {
            #region Singleton
            serviceCollection.AddSingleton<ITenantDbConnectionInfo, TenantDbConnectionInfo>();
            serviceCollection.AddSingleton(typeof(UserAccessConfigInfo));
            #endregion Singleton
        }

    }
}




