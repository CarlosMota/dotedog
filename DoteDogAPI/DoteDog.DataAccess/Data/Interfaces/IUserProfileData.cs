using DoteDog.DataAccess.Models.User;

namespace DoteDog.DataAccess.Data.Interfaces
{
    public interface IUserProfileData
    {
        Task<IEnumerable<UserProfile>> GetUsers();

        Task<IEnumerable<UserProfile>> GetUsers(string userName);
    }
}