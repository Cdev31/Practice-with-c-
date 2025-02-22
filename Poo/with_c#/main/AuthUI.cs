
using poo.services;
using poo.adapter;

namespace main
{
    public class AuthUI
    {

        private readonly AuthServices auth = new AuthServices( new AuthAdapter());
        public bool login(){
            bool isExit = false, isAuthenticated = false;
            int response;
            
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
        public bool register(){
            bool created = false;
          
            do
            {
                Console.WriteLine("Ingrese un nombre de usuario: ");
                string username = Console.ReadLine();

                Console.WriteLine("Ingrese una contraseña de usuario: ");
                string password = Console.ReadLine();

                Console.WriteLine("Ingrese su dui:  ");
                int dui = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su numero de celular : ");
                string number = Console.ReadLine();

                if( auth.register( username, password, dui, number ) == true){
                    created = true;
                    break;
                };

                Console.WriteLine("Credenciales invalidas\n");
                Console.WriteLine("Desea salir?: [1 = si] [2 = no]");
                int response = int.Parse(Console.ReadLine());
                
                if( response == 1) break;

            } while ( true );
            return created;
        }
    }
}