using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Configurations;

public class UserIdentityConfigurations:IEntityTypeConfiguration<ApiUser>
{
    public void Configure(EntityTypeBuilder<ApiUser> builder)
    {
        builder.Property(x => x.EmailConfirmed).HasConversion<int>().HasPrecision(1);
        builder.Property(x => x.TwoFactorEnabled).HasConversion<int>().HasPrecision(1);
        builder.Property(x => x.LockoutEnabled).HasConversion<int>().HasPrecision(1);
        builder.Property(x => x.PhoneNumberConfirmed).HasConversion<int>().HasPrecision(1);
        
    }
}