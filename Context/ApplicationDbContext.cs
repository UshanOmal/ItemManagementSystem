using ItemManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace ItemManagementSystem.Context
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options) 
        { 
        
        
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
