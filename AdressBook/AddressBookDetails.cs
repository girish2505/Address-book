using System;
using System.Collections.Generic;
using System.Text;

namespace AdressBook
{
    class AddressBookDetails
    {
        private List<Person> people;
        private static List<Person> searchContacts = new List<Person>();
        private static List<Person> viewContacts = new List<Person>();
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
                while (true)
                {
                    Console.Write("Enter First Name: ");
                    string firstName = Console.ReadLine();
                    if (people.Count > 0)
                    {
                        var x = people.Find(x => x.FirstName.Equals(firstName));
                        if (x != null)
                        {
                            Console.WriteLine("Your name  already exists");
                        }
                        else
                        {
                            person.FirstName = firstName;
                            break;
                        }
                    }
                    else
                    {
                        person.FirstName = firstName;
                        break;
                    }

                }
                Console.Write("Enter Last Name: ");
                person.LastName = Console.ReadLine();
                Console.Write("Enter Address: ");
                person.Address = Console.ReadLine();
                Console.Write("Enter City: ");
                person.City = Console.ReadLine();
                Console.Write("Enter State: ");
                person.State = Console.ReadLine();
                Console.Write("Enter Zip Code: ");
                person.ZipCode = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Phone Number: ");
                string phNo = Console.ReadLine();
                person.PhoneNumber = phNo;
                Console.Write("Enter Email-id: ");
                string emailId = Console.ReadLine();
                person.Email = emailId;
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
                    Console.WriteLine($"{dict.Key}");
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
            Console.WriteLine($"First Name : {x.FirstName}");
            Console.WriteLine($"Last Name : {x.LastName}");
            Console.WriteLine($"Address : {x.Address}");
            Console.WriteLine($"City : {x.City}");
            Console.WriteLine($"State : {x.State}");
            Console.WriteLine($"Zip Code: {x.ZipCode}");
            Console.WriteLine($"Phone Number: {x.PhoneNumber}");
            Console.WriteLine($"Email: {x.Email}");
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
                    if (editName.ToLower() == person.FirstName.ToLower())
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
                                    person.FirstName = Console.ReadLine();
                                    Console.WriteLine("Firist name Modified");
                                    break;
                                case 2:
                                    Console.WriteLine("Enter New Last name");
                                    person.LastName = Console.ReadLine();
                                    Console.WriteLine("Last name Modified");
                                    break;
                                case 3:
                                    Console.WriteLine("Enter New Address");
                                    person.Address = Console.ReadLine();
                                    Console.WriteLine("Address Modified");
                                    break;
                                case 4:
                                    Console.WriteLine("Enter New City");
                                    person.City = Console.ReadLine();
                                    Console.WriteLine("City Modified");
                                    break;
                                case 5:
                                    Console.WriteLine("Enter New State");
                                    person.State = Console.ReadLine();
                                    Console.WriteLine("State Modified");
                                    break;
                                case 6:
                                    Console.WriteLine("Enter New Zip Code");
                                    person.ZipCode = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("ZipCode Modified");
                                    break;
                                case 7:
                                    Console.Write("Enter new Phone Number: ");
                                    string phNo = Console.ReadLine();
                                    person.PhoneNumber = phNo;
                                    Console.WriteLine("Phone Number Modified");
                                    break;
                                case 8:
                                     Console.Write("Enter new Email-id: ");
                                     string emailId = Console.ReadLine();
                                     person.Email = emailId;
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
                    if (deleteName.ToLower() == x.FirstName.ToLower())
                    {
                        //removing from list
                        Console.WriteLine("***************DELETED****************");
                        Console.WriteLine($"You have deleted {x.FirstName} contact");
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
        public void SearchDetails()
        {
            string personName;
            Console.WriteLine("1. Search by city name\n2.Search By state name\nEnter your option:");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Enter the name of city in which you want to search:");
                    string cityName = Console.ReadLine();
                    Console.WriteLine("Enter the name of person you want to search:");
                    personName = Console.ReadLine();
                    SearchByCityName(cityName, personName);
                    break;
                case 2:
                    Console.WriteLine("Enter the state of city in which you want to search:");
                    string stateName = Console.ReadLine();
                    Console.WriteLine("Enter the name of person you want to search:");
                    personName = Console.ReadLine();
                    SearchByStateName(stateName, personName);
                    break;
                default:
                    return;

            }
        }
            public void SearchByCityName(string cityName, string personName)
        {
            if (addressBookDictionary.Count > 0)
            {

                foreach (KeyValuePair<string, List<Person>> dict in addressBookDictionary)
                {
                    searchContacts = dict.Value.FindAll(x => x.FirstName.Equals(personName) && x.State.Equals(cityName));


                }
                if (searchContacts.Count > 0)
                {
                    foreach (var x in searchContacts)
                    {
                        PrintValues(x);
                    }
                }
                else
                {
                    Console.WriteLine("Person not found");
                }
            }
            else
            {
                Console.WriteLine("Adress book is empty");
            }
        }
        public void SearchByStateName(string stateName, string personName)
        {
            if (addressBookDictionary.Count > 0)
            {

                foreach (KeyValuePair<string, List<Person>> dict in addressBookDictionary)
                {
                    searchContacts = dict.Value.FindAll(x => x.FirstName.Equals(personName) && x.State.Equals(stateName));

                }
                if (searchContacts.Count > 0)
                {
                    foreach (var x in searchContacts)
                    {
                        PrintValues(x);
                    }
                }
                else
                {
                    Console.WriteLine("Person not found");
                }
            }
            else
            {
                Console.WriteLine("Adress book is empty");
            }
        }
        public void ViewDetails()
        {

            Console.WriteLine("1. View by city name\n2.View By state name\nEnter your option:");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Enter the name of city in which you want to view:");
                    string cityName = Console.ReadLine();
                    ViewByCityName(cityName);
                    break;
                case 2:
                    Console.WriteLine("Enter the state of city in which you want to view:");
                    string stateName = Console.ReadLine();
                    ViewByStateName(stateName);
                    break;
                default:
                    return;

            }

        }
        public void ViewByCityName(string cityName)
        {
            if (addressBookDictionary.Count > 0)
            {

                foreach (KeyValuePair<string, List<Person>> dict in addressBookDictionary)
                {
                    viewContacts = dict.Value.FindAll(x => x.State.Equals(cityName));
                }
                if (searchContacts.Count > 0)
                {
                    foreach (var x in searchContacts)
                    {
                        PrintValues(x);
                    }
                }
                else
                {
                    Console.WriteLine("No Persons found");
                }
            }
            else
            {
                Console.WriteLine("Adress book is empty");
            }
        }
        public void ViewByStateName(string stateName)
        {
            if (addressBookDictionary.Count > 0)
            {

                foreach (KeyValuePair<string, List<Person>> dict in addressBookDictionary)
                {
                    viewContacts = dict.Value.FindAll(x => x.State.Equals(stateName));
                }
                if (searchContacts.Count > 0)
                {
                    foreach (var x in searchContacts)
                    {
                        PrintValues(x);
                    }
                }
                else
                {
                    Console.WriteLine("No Persons found");
                }
            }
            else
            {
                Console.WriteLine("Adress book is empty");
            }
        }
    }
}
