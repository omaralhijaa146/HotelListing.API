using HotelListing.API.Contracts;
using HotelListing.API.Data;

namespace HotelListing.API.Reposetories;

public class HotelsRepository: GenericRepository<Hotel>, IHotelsRepository
{
    public HotelsRepository(HotelListingDbContext context) : base(context)
    {
    }
}