using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentACarApplication.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RentACarApplication.Data
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(250)]
        public string FirstName { get; set; }
        [StringLength(250)]
        public string LastName { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        [StringLength(35)]
        public string PostCode { get; set; }
        [ForeignKey("UserId")]
        public virtual UserCar UserCar { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<UserCar> UserCars { get; set; }
    }
}
