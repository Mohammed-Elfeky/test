using System.Collections.Generic;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class THECONTEXT: IdentityDbContext<AppUser>
    {
        public THECONTEXT() : base()
        {

        }

        //injection
        public THECONTEXT(DbContextOptions options) : base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //pass connection option -Migration
        //    optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ITImvc;Integrated Security=True");
        //    base.OnConfiguring(optionsBuilder);
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<OrderProduct>()
                .HasKey(or => new { or.o_id, or.p_id });
        }

        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<crsReault> GetCrsReaults { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<Trainee> Trainees { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderProduct> OrdersProducts { get; set; }
        public virtual DbSet<Product> Products { get; set; }

    }
}
