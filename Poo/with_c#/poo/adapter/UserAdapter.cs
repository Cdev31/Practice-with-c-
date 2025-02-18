
using poo.models;

namespace poo.adapter
{
    public class UserNode {
        public UserModel informationUser;
        public UserNode? next;
        public UserNode? previus;

        public UserNode( UserModel _userData ){
            informationUser = _userData;
            next = null;
            previus = null;
        }
    };

    public class UserAdapter
    {
        private UserNode? head = null;
        private static string[] terms = { "userName", "id", "phoneNumber", "dui" };

        public bool isEmpty(){
            return head == null ;
        }

        public bool isValidTerm( string term ){
            bool existTerm = false;

            for( int i =0; i < 4; i++ ){
                if( term == terms[i]){
                    existTerm = true;
                }
            }

            return existTerm;
        }

        public bool insertUser( UserModel user ){

            UserNode newUser = new UserNode( user );

            newUser.next = head;
            head.previus = newUser;
            head = newUser;

            return true;
        }

        public List<UserModel>? getAllUsers(){
            
            if( isEmpty() ) return null;

            List<UserModel> users = new List<UserModel>();

            UserNode? currentNode = head;

            while( currentNode.next != null ){
                users.Add( currentNode.informationUser );
                currentNode = currentNode.next;
            }

            return users;
        }

        public UserModel? getUserByTerm<T >( string term, T value ) {

            if( isValidTerm( term ) == false ) return null;
            if( isEmpty()) return null;

            UserNode? currentNode = head;

            while( currentNode != null ){
                var property = typeof(UserModel).GetProperty(term);
                if( property != null ){
                    var propertyValue = property.GetValue( currentNode.informationUser );

                    if( propertyValue != null && propertyValue.Equals(value)){
                        return currentNode.informationUser;
                    }
                }
                currentNode = currentNode.next;
            }
            return null;
        }
        
    }
}