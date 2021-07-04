using System;
using System.Collections.Generic;
using System.Text;

namespace AdressBook
{
    class AddressBookDetails
    {
        private List<Person> people;
        private static Dictionary<string, List<Person>> addressBookDictionary = new Dictionary<string, List<Person>>();
        public void AddPerson()
        {
            string addressBookName;
            people = new List<Person>();
            while (true)
            {
                Console.WriteLine("Enter The Name of the Address Book");
                addressBookName = Console.ReadLine();
                //Checking uniqueness of address books
                if (addressBookDictionary.Count > 0)
                {
                    if (addressBookDictionary.ContainsKey(addressBookName))
                    {
                        Console.WriteLine(" address book is already exists");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }

            }

            Console.Write("Enter Number of contacts to add:");
            int numOfContacts = Convert.ToInt32(Console.ReadLine());
            while (numOfContacts > 0)
            {
                //object for person class
                Person person = new Person();

                Console.Write("Enter First Name: ");
                person.firstName = Console.ReadLine();
                Console.Write("Enter Last Name: ");
                person.lastName = Console.ReadLine();
                Console.Write("Enter Address: ");
                person.address = Console.ReadLine();
                Console.Write("Enter City: ");
                person.city = Console.ReadLine();
                Console.Write("Enter State: ");
                person.state = Console.ReadLine();
                Console.Write("Enter Zip Code: ");
                person.zipCode = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Phone Number: ");
                string phNo = Console.ReadLine();
                person.phoneNumber = phNo;
                Console.Write("Enter Email-id: ");
                string emailId = Console.ReadLine();
                person.email = emailId;
                people.Add(person);
                numOfContacts--;
            }
            //adding into address book dictionary
            addressBookDictionary.Add(addressBookName, people);
            Console.WriteLine("Successfully Added");
        }
        public void ListPeople()
        {
            if (addressBookDictionary.Count > 0)
            {
                foreach (KeyValuePair<string, List<Person>> dict in addressBookDictionary)
                {
                    Console.WriteLine("{dict.Key}");
                    foreach (var addressBook in dict.Value)
                    {
                        PrintValues(addressBook);
                    }
                }
            }
            else
            {
                Console.WriteLine("Address Book is Empty");
            }

        }

        //Printing values
        public void PrintValues(Person x)
        {
            Console.WriteLine("First Name : {x.firstName}");
            Console.WriteLine("Last Name : {x.lastName}");
            Console.WriteLine("Address : {x.address}");
            Console.WriteLine("City : {x.city}");
            Console.WriteLine("State : {x.state}");
            Console.WriteLine("Zip Code: {x.zipCode}");
            Console.WriteLine("Phone Number: {x.phoneNumber}");
            Console.WriteLine("Email: {x.email}");
        }
        public void EditDetails()
        {
            int f;
            if (people.Count > 0)
            {
                Console.Write("Enter name of a person you want to edit: ");
                string editName = Console.ReadLine();

                foreach (var person in people)
                {
                    if (editName.ToLower() == person.firstName.ToLower())
                    {
                        while (true)
                        {
                            f = 0;
                            Console.WriteLine("1.First name\n2.Last name\n3.Address\n4.City\n5.State\n6.ZipCode\n7.Phone Number\n8.email\n9.Exit");
                            Console.WriteLine("Enter Option You want to edit");
                            switch (Convert.ToInt32(Console.ReadLine()))
                            {
                                case 1:
                                    Console.WriteLine("Enter New First name");
                                    person.firstName = Console.ReadLine();
                                    Console.WriteLine("Firist name Modified");
                                    break;
                                case 2:
                                    Console.WriteLine("Enter New Last name");
                                    person.lastName = Console.ReadLine();
                                    Console.WriteLine("Last name Modified");
                                    break;
                                case 3:
                                    Console.WriteLine("Enter New Address");
                                    person.address = Console.ReadLine();
                                    Console.WriteLine("Address Modified");
                                    break;
                                case 4:
                                    Console.WriteLine("Enter New City");
                                    person.city = Console.ReadLine();
                                    Console.WriteLine("City Modified");
                                    break;
                                case 5:
                                    Console.WriteLine("Enter New State");
                                    person.state = Console.ReadLine();
                                    Console.WriteLine("State Modified");
                                    break;
                                case 6:
                                    Console.WriteLine("Enter New Zip Code");
                                    person.zipCode = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("ZipCode Modified");
                                    break;
                                case 7:
                                    Console.Write("Enter new Phone Number: ");
                                    string phNo = Console.ReadLine();
                                    person.phoneNumber = phNo;
                                    Console.WriteLine("Phone Number Modified");
                                    break;
                                case 8:
                                     Console.Write("Enter new Email-id: ");
                                     string emailId = Console.ReadLine();
                                     person.email = emailId;
                                     Console.WriteLine("Email id Modified");
                                    break;
                                case 9:
                                    // to exit from main method
                                    Console.WriteLine("Exit");
                                    f = 1;
                                    break;

                            }
                            if (f == 1)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entered name is not in Contact list");
                    }
                }
            }
            else
            {
                Console.WriteLine("Your contact list is empty");
            }
        }
        public void DeleteDetails()
        {
            int f = 0;
            if (people.Count > 0)
            {
                Console.Write("Enter name of a person you want to Delete: ");
                string deleteName = Console.ReadLine();

                foreach (var x in people)
                {
                    if (deleteName.ToLower() == x.firstName.ToLower())
                    {
                        //removing from list
                        Console.WriteLine("***************DELETED****************");
                        Console.WriteLine("You have deleted {x.firstName} contact");
                        people.Remove(x);
                        f = 1;
                        break;
                    }
                }
                if (f == 0)
                {
                    Console.WriteLine("The name you have entered not in the address book");
                }

            }
            else
            {
                Console.WriteLine("Your contact list is empty");
            }
        }
    }
}
