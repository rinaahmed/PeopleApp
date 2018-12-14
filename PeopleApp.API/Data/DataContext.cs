using Microsoft.EntityFrameworkCore;
using PeopleApp.API.Models;

namespace PeopleApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
    }
}