
using poo.models;

namespace poo.adapter
{
    public class AuthAdapter
    {
        public bool login( string username, string password  ){
            UserModel? exitUser = new UserAdapter().getUserByTerm<string>("userName", username);
           
            if( exitUser == null ) return false;

            if(exitUser.password != password) return false;

            return true;
        }
        public bool register( string username, string password, int dui, string phone ){
            
            UserModel user = new UserModel{
                dui = dui,
                userName = username,
                phoneNumber = phone,
                password = password
            };

            return new UserAdapter().insertUser( user );;
            
        }
    }
}