using AutoMapper;
using CleanAr.Domain.Repository;
using CleanAr.Infrastructure.Data;
using CleanAr.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanAr.Infrastracture
{
  public static class ConfigureServices
  {
    public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configuration)
    {

      services.AddDbContext<BlogDbContext>(option =>
        option.UseSqlite(configuration.GetConnectionString("BlogDbContext") ?? throw new InvalidOperationException("Connection Issue"))
      );

      services.AddTransient<IBlogRepository, BlogRepository>();

      return services;
    }
  }
}
