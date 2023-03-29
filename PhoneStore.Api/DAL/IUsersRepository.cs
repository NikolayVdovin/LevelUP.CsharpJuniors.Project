using PhoneStore.Api.DAL.Entities;
using PhoneStore.Api.Models;

namespace PhoneStore.Api.DAL
{
    public interface IUsersRepository
    {
        public Task<IEnumerable<UserEntity>> GetAllUsers();
    }
}
