using Microsoft.EntityFrameworkCore;
using PhoneStore.Api.DAL.Entities;

namespace PhoneStore.Api.DAL
{
    public class UsersDbContext : DbContext
    {
        public DbSet<UserEntity>? Users { get; set; }   
    }
}
