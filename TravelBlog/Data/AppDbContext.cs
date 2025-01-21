using Microsoft.EntityFrameworkCore;
using System;
using TravelBlog.Models;

namespace TravelBlog.Data
{
    public class AppDbContext :DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Post> Posts { get; set; }
    }
}
