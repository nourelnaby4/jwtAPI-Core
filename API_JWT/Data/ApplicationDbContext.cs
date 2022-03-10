using API_JWT.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API_JWT.Data
{
    public class ApplicationDbContext:IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) 
        { 


        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole[]
            {
                new IdentityRole{
                    Id=Guid.NewGuid().ToString(),
                    Name="User",
                    NormalizedName="User".ToUpper(),
                    ConcurrencyStamp=Guid.NewGuid().ToString()
                },
                new IdentityRole{
                    Id=Guid.NewGuid().ToString(),
                    Name="Admin",
                    NormalizedName="Admin".ToUpper(),
                    ConcurrencyStamp=Guid.NewGuid().ToString()
                },
            });
        }


    }
}
