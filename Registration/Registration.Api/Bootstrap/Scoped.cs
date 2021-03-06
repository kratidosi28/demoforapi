#region Namespace
using Microsoft.Extensions.DependencyInjection;
using Registration.Infrastructure.Security;
using RxWeb.Core.Data;
using RxWeb.Core.Security;
using RxWeb.Core.Annotations;
using RxWeb.Core;
using Registration.UnitOfWork.DbEntityAudit;
using Registration.BoundedContext.Main;
using Registration.UnitOfWork.Main;
using Registration.Domain.RegisterModule;
            #endregion Namespace




namespace Registration.Api.Bootstrap
{
    public static class ScopedExtension
    {

        public static void AddScopedService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRepositoryProvider, RepositoryProvider>();
            serviceCollection.AddScoped<ITokenAuthorizer, TokenAuthorizer>();
            serviceCollection.AddScoped<IModelValidation, ModelValidation>();
            serviceCollection.AddScoped<IAuditLog, AuditLog>();
            serviceCollection.AddScoped<IApplicationTokenProvider, ApplicationTokenProvider>();
            serviceCollection.AddScoped(typeof(IDbContextManager<>), typeof(DbContextManager<>));

            #region ContextService

            serviceCollection.AddScoped<ILoginContext, LoginContext>();
            serviceCollection.AddScoped<ILoginUow, LoginUow>();
                        serviceCollection.AddScoped<IRegisterContext, RegisterContext>();
            serviceCollection.AddScoped<IRegisterUow, RegisterUow>();
            #endregion ContextService




            #region DomainService

            
            serviceCollection.AddScoped<IRegisteredDomain, RegisteredDomain>();
            #endregion DomainService

        }
    }
}




