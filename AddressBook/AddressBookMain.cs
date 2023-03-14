using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookMain
    {
        
        List<Address> list = new List<Address>();
        public void addContact()
        {
            Address address = new Address();
            Console.Write("Enter firstName: ");
            address.firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            address.lastName = Console.ReadLine();
            Console.Write("Enter Address: ");
            address.address = Console.ReadLine();
            Console.Write("Enter city: ");
            address.city = Console.ReadLine();
            Console.Write("Enter state: ");
            address.state = Console.ReadLine();
            Console.Write("Enter phone umber: ");
            address.phoneNumber = Console.ReadLine();
            Console.Write("Enter email: ");
            address.eMail = Console.ReadLine();
            list.Add(address);
       }
        public void displayContact()
        {
            foreach (var address in list)
            {
                Console.WriteLine(address.firstName + "\n" + address.lastName + "\n" + address.address + "\n" + address.city + "\n" + address.state + "\n" + address.phoneNumber + "\n" + address.eMail);
            }
        }
    }
}
