using Continental.CUP.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Continental.CUP.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet <UserLoginEModel>Users { get; set; }
        public DbSet<OrderEModel> Order { get; set; }
        public DbSet<ReaderEModel> Reader { get; set; }
        public DbSet<OrderDetailEModel> OrderDetail { get; set; }
    }
}
