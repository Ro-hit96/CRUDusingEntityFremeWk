using Microsoft.EntityFrameworkCore;
using CRUDusingEntityFremeWk.Models;


namespace CRUDusingEntityFremeWk.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op)
        {
        }
        public DbSet<Book> Books {get;set;}
    }
}
