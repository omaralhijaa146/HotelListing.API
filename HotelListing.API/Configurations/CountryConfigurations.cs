﻿using HotelListing.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Configurations;

public class CountryConfigurations:IEntityTypeConfiguration<Country>
{
    public void Configure(EntityTypeBuilder<Country> builder)
    {
        
        builder.HasData(
            new Country
            {
                Id=1,
                Name = "Jamaica",
                ShortName = "JM"
            },
            new Country
            {
                Id=2,
                Name = "Bahamas",
                ShortName = "BS"
            },
            new Country
            {
                Id = 3,
                Name = "Cayman Island",
                ShortName = "CI"
            }
            );
    }
}