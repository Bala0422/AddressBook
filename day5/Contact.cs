using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day5
{
    public class Contact
    {
        public string firstName;
        public string lastName;
        public string address;
        public string city; 
        public string state;
        public string email;
        public int Zip;
        public long phoneNumber;

        public int length;

        public Contact(string fname, string lname, string address, string city, string state, string email, int zip, long phone) {
            
            this.firstName = fname;
            this.lastName = lname;
            this.address = address;
            this.city = city;
            this.state = state;
            this.email = email;
            this.Zip= zip;
            this.phoneNumber = phone;

            this.length++;
        }

    }
}
