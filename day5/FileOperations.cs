using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace day5
{
    public class FileOperations
    {

        //UC13

        public void WriteIntoTextFile(AddressBook book)
        {
            string path = "C:\\Users\\223089624\\source\\repos\\day5\\day5\\ContactFile.txt";

            foreach (Contact c in book.Contacts)
            {
                File.AppendAllText(path, c.GiveData(c));
            }

        }

    }
}
