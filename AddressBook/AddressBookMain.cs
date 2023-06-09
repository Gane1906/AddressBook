﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AddressBook
{
    public class AddressBookMain
    {
        List<Address> list = new List<Address>();
        public void addContact()
        {
            //List<Address> list = new List<Address>();
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
            Console.Write("Enter phone number: ");
            address.phoneNumber = Console.ReadLine();
            Console.Write("Enter email: ");
            address.eMail = Console.ReadLine();
            list.Add(address);
       }
        public void displayContact()
        {
            foreach(var data in list)
            {
                Console.WriteLine(data.firstName+"\t"+data.lastName+"\t"+data.address+"\t"+data.city+"\t"+data.state+"\t"+data.phoneNumber+"\t"+data.eMail);
            }
        }
        public void editContact()
        {
            Console.WriteLine("Edit by using First Name: ");
            String name = Console.ReadLine();
            foreach(var data in list)
            {
                if (data.firstName == name)
                {
                    Console.WriteLine("Enter option to edit:\n1.First Name\n2.Second Name\n3.Address\n4.city\n5.state\n6.phone number\n7.email");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter first name ");
                            data.firstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter last number ");
                            data.lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter address");
                            data.address = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter city");
                            data.city = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter state");
                            data.state = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter phne number");
                            data.phoneNumber = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Enter email");
                            data.eMail = Console.ReadLine();
                            break;
                    }
                }
            }
        }
        public void deleteContact()
        {
            Address address = new Address();
            Console.WriteLine("Enter name to delete details");
            String name = Console.ReadLine();
            foreach(var data in list)
            {
                if (data.firstName.Equals(name))
                    address = data;
            }
            list.Remove(address);
        }
    }
}
