
using poo.models;

namespace poo.adapter
{
    public class AuthAdapter
    {
        public bool login( string username, string password  ){
            UserModel? exitUser = new UserAdapter().getUserByTerm<string>("username", username);

            if( exitUser == null ) return false;

            if(exitUser.password != password) return false;

            return true;
        }
    }
}