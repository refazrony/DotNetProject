﻿using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanAr.Infrastracture
{
    public static  class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configuration) { 
        

        
          return services;
        }
    }
}
