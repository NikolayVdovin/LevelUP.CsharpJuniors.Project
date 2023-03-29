using PhoneStore.Api.Models;

namespace PhoneStore.Api.Services
{
    public interface IUsersService
    {
        Task<IEnumerable<UserItem>> AddUser(string Name, bool IsAdmin);
        Task<IEnumerable<UserItem>> GetAllUsers();
    }
}
