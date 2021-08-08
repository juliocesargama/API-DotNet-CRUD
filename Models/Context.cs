using Microsoft.EntityFrameworkCore;

namespace CRUDAPI.Models
{
    public class Context : DbContext
    {
        public DbSet<Person> Persons { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }
    }
}