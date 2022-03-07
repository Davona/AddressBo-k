using AddressBoоk.Models;
using Microsoft.EntityFrameworkCore;

namespace AddressBoоk.Data
{
    public class AddressBookDbContext:DbContext
    {
        public AddressBookDbContext(DbContextOptions<AddressBookDbContext>options):base(options)
        {

        }
        public DbSet<ContactViewModel> Contact { get; set; }
    }
}
