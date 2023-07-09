using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivery.Managment.Persistence
{
    public class DeliveryManagmentDbContexFactory : IDesignTimeDbContextFactory<DeliveryManagmentDbContext>
    {
        public DeliveryManagmentDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<DeliveryManagmentDbContext>();
            var connectionString = configuration.GetConnectionString("EmployeeManagementConnectionString");

            builder.UseSqlServer(connectionString);

            return new DeliveryManagmentDbContext(builder.Options);
        }
    }
}