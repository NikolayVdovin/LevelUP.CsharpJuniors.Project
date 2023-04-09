using PhoneStore.Api.DAL;
using PhoneStore.Api.Models;

namespace PhoneStore.Api.Services
{
    public sealed class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;
        public UsersService(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;
        }

        public async Task<IEnumerable<UserItem>> AddUser(string Name, bool IsAdmin)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserItem>> GetAllUsers()
        {
            var entities = await _usersRepository.GetAllUsers();
            return entities.Select(e => new UserItem(e.Id, e.Name, e.IsAdmin));
        }
    }
}
