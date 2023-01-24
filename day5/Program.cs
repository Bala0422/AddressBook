using System;

namespace day5 
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddressBook book = new AddressBook();

            Contact contact1 = new Contact("Bala", "Murugan", "ge digital", "bengaluru", "Karnataka", "bala@gmail.com", 1234, 9994072206);
            Contact contact2 = new Contact("Raja", "raja", "ge digital", "hydrabad", "hydrabad", "raja@gmail.com", 1234, 9995572206);
            Contact contact3 = new Contact("Sai", "raja", "ge digital", "bengaluru", "Karnataka", "raja@gmail.com", 1234, 9995572206);

            book.AddContact(contact1);
            book.AddContact(contact2);
            book.AddContact(contact3);

            // book.EditContact("Bala");

            // book.RemoveContact(contact1);

            // book.Display();

            book.Search("hydrabad");


        }
    }
}