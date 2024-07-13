using HotelListing.API.Models.Hotel;

namespace HotelListing.API.Models.Country;

public  class CountryDetailsDto:CountryBaseDto
{
    public int Id { get; set; }
    
    public virtual List<HotelDto>? Hotels { get; set; }

}