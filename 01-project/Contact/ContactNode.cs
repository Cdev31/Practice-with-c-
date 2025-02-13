namespace Contact
{
    public struct ContactInfo{
         public string contactName;
         public int contactAge;

         public string phoneNumber;

         public string dui;

         public ContactInfo( string _contactName, int _age, string _number, string _dui ){
            contactName = _contactName;
            contactAge = _age;
            phoneNumber = _number;
            dui = _dui;
         }

    }

    public class ContactNode{
        public ContactInfo contact { get; set; } 

        public ContactNode? next { get; set; } 

        public ContactNode( ContactInfo _contact ){
             contact = _contact;
             next = null;
        }

    }

}