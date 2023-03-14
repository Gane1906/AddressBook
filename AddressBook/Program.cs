using System;
namespace AddressBook
{
    public class Program
    {
        static void Main(String[] args)
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
        }
    }
}