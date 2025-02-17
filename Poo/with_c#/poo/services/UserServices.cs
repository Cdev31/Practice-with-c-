
using poo.adapter;
using poo.interfaces;
using poo.models;

namespace poo.services
{
    public class UserServices : IUser
    {
        UserAdapter userAdapter;
        public UserServices( UserAdapter _userAdapter ){
            userAdapter = _userAdapter;
        }
        public List<UserModel>? findAllUsers()
        {
            List<UserModel>? users = userAdapter.getAllUsers();

            if( users != null ) return users;

            return null;
        }

        public UserModel findById(int id)
        {
            throw new NotImplementedException();
        }
    }
}