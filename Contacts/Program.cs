using System;
using Contact;

namespace Contacts 
{
    class Program{

        private static void menu(int option, ContactList contact){
            int age;
            string name,number,dui;

            switch (option)
            {
                case 1:
                    Console.WriteLine("Ingrese el nombre del contacto: ");
                    name = Console.ReadLine();

                    Console.WriteLine("Ingrese el dui del contacto: ");
                    dui = Console.ReadLine();

                    Console.WriteLine("Ingrese el numero del contacto: ");
                    number = Console.ReadLine();

                    Console.WriteLine("Ingrese la edad del contacto: ");
                    age = int.Parse( Console.ReadLine());

                    contact.insertAtBeggining( new ContactInfo(name,age,dui,number));
                break;

                case 2:
                 contact.showContacts();
                break;
            }

        }
        static void Main( string[] args ){
            string response = "no";
            ContactList contactList = new ContactList();

            do
            {
              Console.WriteLine("--------Bienvenido a la insercion de informacion---------");
              Console.WriteLine("1-Insertar contacto.");
              Console.WriteLine("2-listar contactos.");
              int option  = int.Parse(Console.ReadLine());

              menu(option, contactList );
              Console.WriteLine("Desea salir? [si] [no]");
              response = Console.ReadLine();  
 
            } while (response == "no");
            
        }
    }
}