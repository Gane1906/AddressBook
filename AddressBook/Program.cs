﻿using System;
namespace AddressBook
{
    public class Program
    {
        static void Main(String[] args)
        {
            AddressBookDictonary dict = new AddressBookDictonary();
            bool flag = true;
            while (flag)
            {        
                Console.Write("1.Add Contact\n2.Display\n3.Exit\nEnter your option: ");
                 int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        dict.AddAddress();
                        break;
                    case 2:
                        dict.Display();
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
    
}