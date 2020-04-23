using Microsoft.AspNetCore.Hosting;

namespace WebMotorsTeste.Application.Service
{
    public class HostingEnvironmentService
    {
        public static IHostingEnvironment Environment;
        public static void Load(IHostingEnvironment env)
        {
            Environment = env;
        }
    }
}
