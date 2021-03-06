﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Monaco.Data.Core.DbContexts;

namespace Monaco.Data.Core.Infrastructure.Extensions
{
    /// <summary>
    /// Represents extensions of IServiceCollection
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Register database context
        /// </summary>
        /// <param name="services">Collection of service descriptors</param>
        public static void AddMonacoDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            // Register database context from application configuration
            services.AddDbContext<MonacoDbContext>(optionsBuilder =>
            {
                optionsBuilder.UseNpgsql(configuration["Data:ConnectionString"]);
            });
        }
    }
}
