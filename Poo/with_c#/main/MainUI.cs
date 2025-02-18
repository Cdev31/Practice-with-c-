
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

            } while ( response != 4);
        }
        public void execute(){
            
            AuthUI authUI = new AuthUI();

            do
            {
                isAuthenticated = authUI.login();
            } while ( isAuthenticated == false );

            if( isAuthenticated == true ){
                menu();
            }

        }
    }
}