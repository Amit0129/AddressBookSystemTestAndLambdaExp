using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookBuilder
    {
        public void Operations()
        {
            AddressBook records = new AddressBook(); // Creating a object of AddressBook class
            string ab;
            while (true)
            {
                Console.WriteLine("\n\nWelcome to Address Book System");
                Console.WriteLine("1. Add a new Record");
                Console.WriteLine("2. Update a Record");
                Console.WriteLine("3. Delete a Record");
                Console.WriteLine("4.Exit");
                Console.WriteLine("\nEnter your choice : ");

                int choice = Convert.ToInt32(Console.ReadLine());// Storing a user choice in variable
                switch (choice)
                {
                    case 1:
                        string adrsBookName;
                        Console.WriteLine("\nDo you want to add records in new Address Book ? If yes then press 1 : ");
                        string chose = Console.ReadLine();
                        if (chose == "1")
                        {
                            Console.WriteLine("\nEnter name of address book which you want to create : ");
                            adrsBookName = Console.ReadLine();
                            records.CreateAddressBook(adrsBookName); 
                            records.AddRecords(adrsBookName);
                            records.DisplayDictionary(); 

                        }
                        else
                        {
                            records.DiplayListOfAddressBook();// Displaying existing address book name
                            if (records.temp == 1) //Checking that address book is empty or not
                            {
                                Console.WriteLine("\nPlease Add Address Book First by entering choice 1");
                                Operations();
                            }
                            else
                            {
                                Console.WriteLine("\nSelect any one address book from above list : ");
                                ab = Console.ReadLine(); 
                                records.AddRecords(ab);
                                records.DisplayDictionary();
                            }
                        }
                        break;
                    case 2:
                        records.DiplayListOfAddressBook();// Displaying existing address book name
                        if (records.temp == 1)//Checking that address book is empty or not
                        {
                            Console.WriteLine("\nPlease Add Address Book First by entering choice 1");
                            Operations();
                        }
                        else
                        {
                            Console.WriteLine("\nSelect any one address book from above list : ");
                            ab = Console.ReadLine();// Storing a address book name which is provided by user
                            records.UpdateRecords(ab); // Calling a method of AddressBook class to update record to Address Book
                            records.DisplayDictionary(); // Displaying all records of All Address book
                        }
                        break;
                    case 3:
                        records.DiplayListOfAddressBook(); // Displaying existing address book name
                        if (records.temp == 1) //Checking that address book is empty or not
                        {
                            Console.WriteLine("\nPlease Add Address Book First by entering choice 1");
                            Operations();
                        }
                        else
                        {
                            Console.WriteLine("\nSelect any one address book from above list : ");
                            ab = Console.ReadLine(); // Storing a address book name which is provided by user                  
                            records.DeleteRecord(ab);// Calling a method of AddressBook class to delete record of address book
                            records.DisplayDictionary(); // Displaying all records of All Address book
                        }
                        break;
                    case 4:
                        System.Environment.Exit(0); // Exit
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
