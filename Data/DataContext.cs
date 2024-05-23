using Microsoft.EntityFrameworkCore;
using ReservationSystemAPI.Models;

namespace ReservationSystemAPI.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> users {  get; set; }
        public DataContext(DbContextOptions options) : base(options)
        { 
            
        }

    }
}
