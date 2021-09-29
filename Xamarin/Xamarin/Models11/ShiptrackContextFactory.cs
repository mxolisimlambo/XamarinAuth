using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xamarin.Models
{
    public class ShiptrackContextFactory : IDesignTimeDbContextFactory<ShiptrackDbContext>
    {
        public ShiptrackDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ShiptrackDbContext>();
            //optionsBuilder.UseSqlServer("Data Source=blog.db");

            return new ShiptrackDbContext(optionsBuilder.Options);
        }
    }
}
