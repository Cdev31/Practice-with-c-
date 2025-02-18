
using poo.services;
using poo.adapter;

namespace main
{
    public class AuthUI
    {

        public bool login(){
            bool isExit = false, isAuthenticated = false;
            int response;
            AuthServices auth = new AuthServices( new AuthAdapter());
            do
            {
                Console.WriteLine("Inserte el nombre de usuario: ");
                string username = Console.ReadLine();

                Console.WriteLine("Inserte su contraseña de usuario: ");
                string password = Console.ReadLine();

                if( auth.login( username, password ) == true ) {
                    isExit = true;
                    isAuthenticated = true;
                    Console.WriteLine("Bienvenido");
                }

                Console.WriteLine("Credenciales invalidas\n");
                Console.WriteLine("Desea salir?: [1 = si] [2 = no]");
                response = int.Parse(Console.ReadLine());

                if( response == 1) break;
                
            } while ( isExit == false );

            return isAuthenticated;
        }
    }
}