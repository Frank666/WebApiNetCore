using Microsoft.EntityFrameworkCore;
using api_ef.Models;

namespace api_ef.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Character> Characters { get; set; }


    }
}