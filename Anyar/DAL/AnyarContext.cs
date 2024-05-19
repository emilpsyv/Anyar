using Anyar.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Anyar.DAL
{
    public class AnyarContext : IdentityDbContext
    {
        public AnyarContext(DbContextOptions<AnyarContext> options) :base(options)
        {

        }
        DbSet<Employee> Employess { get; set;}
            
        



    }
}
