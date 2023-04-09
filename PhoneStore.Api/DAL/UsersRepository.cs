using PhoneStore.Api.DAL.Entities;

namespace PhoneStore.Api.DAL
{
    public class UsersRepository : IUsersRepository
    {
        private readonly UsersDbContext _dbContext;
        public UsersRepository(UsersDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<IEnumerable<UserEntity>> GetAllUsers()
        {
            return Task.FromResult(Enumerable.Empty<UserEntity>());
        }
    }
}
