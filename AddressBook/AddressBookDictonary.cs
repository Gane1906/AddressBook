using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookDictonary
    {
        Dictionary<string, List<Address>> addressList = new Dictionary<string, List<Address>>();
        public void AddAddress()
        {
            List<Address> list = new List<Address>();
            Address address = new Address();
            Console.Write("Enter firstName: ");
            address.firstName = Console.ReadLine();
            if(addressList.ContainsKey(address.firstName))
            {
                Console.WriteLine("Duplicate entries are not possible");
            }
            else
            {
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
                addressList.Add(address.firstName, list);
            }
        }
        public void Display()
        {
            foreach(var key in addressList.Keys)
            {
                Console.WriteLine("key is: "+key);
                Console.WriteLine("Details are");
                foreach(var items in addressList[key])
                    Console.WriteLine(items.firstName+"\t"+items.lastName+"\t"+items.address+"\t"+items.city+"\t"+items.state+"\t"+items.phoneNumber+"\t"+items.eMail);
            }
        }
        public void SearchByCity()
        {
            Console.WriteLine("Eter city to search");
            string city=Console.ReadLine();
            Console.WriteLine("The people in {0} city are: "+city);
            foreach (var key in addressList.Keys)
            {
                foreach(var value in addressList[key].Where(v=>v.city.Equals(city)).ToList())
                {
                    Console.WriteLine(value.firstName + "\t" + value.lastName + "\t" + value.address + "\t" + value.city + "\t" + value.state + "\t" + value.phoneNumber + "\t" + value.eMail);
                }
            }
        }
        public void SearchByState()
        {
            Console.WriteLine("Eter state to search");
            string state = Console.ReadLine();
            Console.WriteLine("The people in {0} city are: " + state);
            foreach (var key in addressList.Keys)
            {
                foreach (var value in addressList[key].Where(v=>v.state.Equals(state)).ToList())
                {
                    Console.WriteLine(value.firstName + "\t" + value.lastName + "\t" + value.address + "\t" + value.city + "\t" + value.state + "\t" + value.phoneNumber + "\t" + value.eMail);

                }
            }
        }
    }
}
