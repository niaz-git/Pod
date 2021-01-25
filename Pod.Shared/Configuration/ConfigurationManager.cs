using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Pod.Shared.Configuration
{
        public static class ConfigurationManager
        {
            private static IConfigurationRoot configuration;
            static ConfigurationManager()
            {
                Build();
            }
            public static string GetConnectionString(string name = "DataConnection")
            {
                string result = configuration.GetConnectionString(name);
                return result;
            }
            private static void Build()
            {
                var builder = new ConfigurationBuilder()
                     .SetBasePath(Directory.GetCurrentDirectory())
                     .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
                configuration = builder.Build();
            }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
        }
    }
}
