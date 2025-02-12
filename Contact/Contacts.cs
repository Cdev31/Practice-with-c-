
namespace Contact;

public class ContactList
{
    private ContactNode head = null;

    public void insertAtBeggining( ContactInfo contact ){
        ContactNode newContact = new ContactNode( contact );
        newContact.next = head;
        head = newContact;
    }

    public void showContacts(){

        if( head == null ){
            Console.WriteLine("No existen contactos");
            return;
        }
        
        ContactNode firstContact = head;

        while( firstContact.next != null ){
            Console.Write(firstContact.contact.contactName);
            firstContact = firstContact.next;
        }
        Console.Write(firstContact.contact.contactName);
    }
}