﻿namespace day5
{
    public class AddressBook
    {

        public List<Contact> Contacts = new List<Contact>();

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
            Console.WriteLine("Contact Added");
        }

        public void EditContact(string fname)
        {
            foreach (Contact contact in Contacts)
            {
                if (contact.firstName == fname)
                {
                    Console.WriteLine("To edit fristName(1), Lastname(2), address(3), city(4), state(5), email(6), zip(7), phone(8)");
                    Console.WriteLine("Enter 0 to exit or use the numbers to edit respective feilds");
                    while (true)
                    {
                        int inp = Convert.ToInt32(Console.ReadLine());
                        if (inp == 0)
                        {
                            Console.WriteLine("Contacts Updated!!");
                            break;
                        }
                        switch (inp)
                        {
                            case 1:
                                Console.WriteLine("Enter the First name:");
                                contact.firstName = Console.ReadLine();
                                break;

                            case 2:
                                Console.WriteLine("Enter the Last name:");
                                contact.lastName = Console.ReadLine();

                                break;
                            case 3:
                                Console.WriteLine("Enter the address name:");
                                contact.address = Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine("Enter the city name:");
                                contact.city = Console.ReadLine();
                                break;
                            case 5:
                                Console.WriteLine("Enter the State name:");
                                contact.state = Console.ReadLine();
                                break;
                            case 6:
                                Console.WriteLine("Enter the email name:");
                                contact.email = Console.ReadLine();
                                break;
                            case 7:
                                Console.WriteLine("Enter the zip:");
                                contact.Zip = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 8:
                                Console.WriteLine("Enter the Phone Number:");
                                contact.phoneNumber = Convert.ToInt64(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("Enter a vaild number");
                                break;

                        }
                    }
                }

            }
        }

    public void RemoveContact(Contact contact)
    {

        Console.WriteLine("Contact Removed");
        Contacts.Remove(contact);
    }

}
}
