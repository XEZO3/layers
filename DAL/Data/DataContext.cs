using Microsoft.EntityFrameworkCore;
using Models.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Category> categories { get; set; }
        public DbSet<Courses> Courses { get; set; }
        //public DbSet<OrderItem> orderItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            //DESKTOP-JD76U9C
            //LAPTOP-BFFJ9SQ9
            builder.UseSqlServer("Server=DESKTOP-JD76U9C;Database=ApiStudents;Trusted_Connection=True;Trust Server Certificate=true;");
        }
    }
}
