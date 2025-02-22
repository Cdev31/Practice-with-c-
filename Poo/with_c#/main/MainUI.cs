
namespace main
{
    public class MainUI
    {
        bool isAuthenticated = false;

        public void menu(){
            int response = 0 ;

            do
            {
                Console.WriteLine(" Escoga entre las siguientes opciones: \n");
                Console.WriteLine("1- Administrar usuarios\n");
                Console.WriteLine("2- Administrar libros");
                Console.WriteLine("3- Administrar peliculas \n");
                Console.WriteLine("4- Salir \n");
                response = int.Parse(Console.ReadLine());

                // switch (response)
                // {
                
                //     default:
                // }

            } while ( response != 4);
        }
        public void execute(){
            
            AuthUI authUI = new AuthUI();
            UserUI userUI = new UserUI();
            int response = 0;

            do
            {
                Console.WriteLine("Bienvenido a su app");

                Console.WriteLine("1-Iniciar Sesion");
                Console.WriteLine("2-Registrarse");
                Console.WriteLine("3- Salir");
                response = int.Parse(Console.ReadLine());

                switch (response)
                {
                    case 1:
                    userUI.findUsers();
                    //   bool isAuth = authUI.login();
                    //   if( isAuth == true) {
                    //     isAuthenticated = true;
                    //     response = 3;
                    //   };
                      break;
                    case 2:
                       bool isRegister = authUI.register();
                       if( isRegister == true ) response = 1;
                       break;
                }
                
            } while ( response != 3 );

            if( isAuthenticated == true ){
                menu();
            }

        }
    }
}