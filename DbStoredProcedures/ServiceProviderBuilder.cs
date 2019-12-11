using DbStoredProcedures.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DbStoredProcedures
{
    public class ServiceProviderBuilder
    {
        public ServiceProvider Build(IConfiguration configuration)
        {
            ServiceProvider serviceProvider = new ServiceCollection()
                .AddLogging()
                .AddDbContext<IssueTrackerContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DbConnection")))
                .BuildServiceProvider();                    

            return serviceProvider;
        }
    }
}
