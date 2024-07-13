

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data;


public class ApiUser:IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}