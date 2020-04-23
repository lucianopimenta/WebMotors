using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebMotorsTeste.Core.Interface;
using WebMotorsTeste.Data.Context;

namespace WebMotorsTeste.Application.Helper
{
    public static class DatabaseHelper
    {
        public static void ConfigureService(IServiceCollection services)
        {
            var stringConexaoComBancoDeDados = SettingsDefault.connectionString();
            services.AddDbContext<WebMotorsContext>(options =>
                options.UseSqlServer(stringConexaoComBancoDeDados).EnableSensitiveDataLogging());

            services.AddScoped<IDbContext, WebMotorsContext>();
        }

        public static WebMotorsContext GetInstance()
        {
            var optionsBuilder = new DbContextOptionsBuilder<WebMotorsContext>();
            optionsBuilder.UseSqlServer(SettingsDefault.connectionString());

            return new WebMotorsContext(optionsBuilder.Options);
        }
    }
}
