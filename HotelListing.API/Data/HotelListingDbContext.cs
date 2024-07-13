using System.Reflection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.General;

namespace HotelListing.API.Data;

public class HotelListingDbContext:IdentityDbContext<ApiUser>
{
    public DbSet<Country> Countries { get; set; }
    public DbSet<Hotel> Hotels { get; set; }

    public HotelListingDbContext(DbContextOptions<HotelListingDbContext> options):base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
       
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}




