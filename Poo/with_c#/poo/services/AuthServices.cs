
using poo.adapter;
using poo.interfaces;

namespace poo.services
{
    public class AuthServices : IAuth
    {
        private AuthAdapter authAdapter;
        public AuthServices( AuthAdapter _authAdapter ){
            authAdapter = _authAdapter;
        }
        public bool login(string username, string password)
        {
           return authAdapter.login( username, password );
        }

        public bool register( string username, string password, int dui, string phone ){
            return authAdapter.register( username, password, dui, phone );
        }
    }
}