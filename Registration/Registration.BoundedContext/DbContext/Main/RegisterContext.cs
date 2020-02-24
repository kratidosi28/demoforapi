using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Registration.BoundedContext.SqlContext;
using Registration.Models.Main;
using Registration.Models;
using Registration.BoundedContext.Singleton;
using RxWeb.Core.Data;
using RxWeb.Core.Data.Models;
using RxWeb.Core.Data.BoundedContext;

namespace Registration.BoundedContext.Main
{
    public class RegisterContext : BaseBoundedContext, IRegisterContext
    {
        public RegisterContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

            #region DbSets
                public DbSet<Registered>Registereds { get; set; }
            #endregion DbSets

    }


    public interface IRegisterContext : IDbContext
    {
    }
}

