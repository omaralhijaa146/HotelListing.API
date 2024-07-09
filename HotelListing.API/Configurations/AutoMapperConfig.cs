using AutoMapper;
using HotelListing.API.Data;
using HotelListing.API.Models.Country;

namespace HotelListing.API.Configurations;

public class AutoMapperConfig:Profile
{
    public AutoMapperConfig()
    {
        CreateMap<Country, CreateCountryDto>().ReverseMap();
        CreateMap<Country, CountryDto>().ReverseMap();
        CreateMap<Country, CountryDetailsDto>().ReverseMap();
        CreateMap<Country, UpdateCountryDto>().ReverseMap();
        CreateMap<Hotel, HotelDto>().ReverseMap();
    }
}