﻿using Microsoft.Extensions.Configuration;

namespace WebMotorsTeste.Application.Helper
{
    public static class SettingsDefault
    {
        public const string DefaultConnection = "WebMotors";
        public static IConfigurationRoot settings;

        public static void Load(IConfigurationRoot configuracao)
        {
            settings = configuracao;
        }

        public static string connectionString()
        {
            return settings.GetConnectionString(DefaultConnection);
        }
    }
}
