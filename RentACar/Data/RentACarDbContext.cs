using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RentACar.Models;

namespace RentACar.Data
{
    public class RentACarDbContext : DbContext
    {
        public RentACarDbContext (DbContextOptions<RentACarDbContext> options)
            : base(options)
        {
        }

        public DbSet<RentACar.Models.Car> Cars { get; set; }
    }
}
