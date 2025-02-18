using poo.models;

namespace poo.interfaces
{
    public interface IUser
    {
        List<UserModel>? findAllUsers();

        UserModel? findById( int id );

        UserModel? findByUsername( string username );
        
    }
}