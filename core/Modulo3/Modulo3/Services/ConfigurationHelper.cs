using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modulo3.Services
{
    public static class ConfigurationHelper
    {
        public static IConfigurationRoot GetConfiguration(string path, string envorionmentName = null)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(path)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            if (!String.IsNullOrWhiteSpace(envorionmentName))
            {
                builder = builder.AddJsonFile($"appsettings.{envorionmentName}.json", optional: true);
            }
            builder = builder.AddEnvironmentVariables();

            return builder.Build();
        }
             
    }
}
