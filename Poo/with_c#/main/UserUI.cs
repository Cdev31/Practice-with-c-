
using poo.adapter;
using poo.models;
using poo.services;

namespace main
{
    public class UserUI
    {
        private readonly UserServices userServices = new UserServices( new UserAdapter() ); 
        public void findUsers(){
            Console.WriteLine("--------------------Usuarios del sistema--------------\n");
            List<UserModel>? users = userServices.findAllUsers();

            if( users == null ) {
                Console.WriteLine("Users not found");
                return;
            }

            foreach (UserModel user in users)
            {
                Console.WriteLine("username:" + user.userName);
                Console.WriteLine("number: " + user.phoneNumber);
                Console.Write("\n");
            }
        }
        public void deleteUser(){}
        public void updateUserInfo(){}
    }
}