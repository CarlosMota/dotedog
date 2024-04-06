using DoteDog.DataAccess.Data.Interfaces;
using DoteDog.DataAccess.DataAccess;
using DoteDog.DataAccess.Models.User;

namespace DoteDog.DataAccess.Data.Implementations
{
    public class UserProfileData : IUserProfileData
    {
        private readonly ISqlDataAccess _dataAccess;

        public UserProfileData(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<IEnumerable<UserProfile>> GetUsers() =>
            _dataAccess.LoadData<UserProfile, dynamic>("select * from fc_UserProfile_Get()", new { });

        public Task<IEnumerable<UserProfile>> GetUsers(string userName) =>
            _dataAccess.LoadData<UserProfile, dynamic>("select * from fc_UserProfile_Get(@P_UserName)", new { P_UserName = userName });


    }
}