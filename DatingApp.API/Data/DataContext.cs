using datingApp.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace datingApp.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Value> Values { get; set; }
    }
}