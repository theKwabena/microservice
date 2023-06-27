using Microsoft.EntityFrameworkCore;

namespace microservice.Models
{
    public class apidbcontext : DbContext
    {
        public apidbcontext(DbContextOptions<apidbcontext> options) : base(options)
        {
                
        }
        public DbSet<Todo> todos { get; set; }
    }
}
