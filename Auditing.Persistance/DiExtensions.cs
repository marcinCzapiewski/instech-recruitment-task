﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Auditing.Persistance;
public static class DiExtensions
{
    public static IServiceCollection RegisterPersistance(this IServiceCollection services, IConfiguration configuration)
    {
        // TODO rename connection string
        services.AddDbContext<AuditContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
      
        return services;
    }
}
