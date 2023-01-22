using System;

namespace day5 
{
    public class Program
    {
        static void Main(string[] args)
        {
            AddressBook book = new AddressBook();

            Contact contact1 = new Contact("Bala", "Murugan", "ge digital", "bengaluru", "Karnataka", "bala@gmail.com", 1234, 9994072206);

            book.AddContact(contact1);

            book.EditContact("Bala");

            book.RemoveContact(contact1);


        }
    }
}