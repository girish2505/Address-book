using System;
using System.Collections.Generic;
using System.Text;

namespace AdressBook
{
    class AddressBookDetails
    {
        private static List<Person> People = new List<Person>();
        public static void AddPerson()
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
            person.phoneNumber = Console.ReadLine(); ;
            Console.Write("Enter Email id :");
            person.email = Console.ReadLine();


            People.Add(person);

        }

        public static void ListPeople()
        {
            if (People.Count > 0)
            {
                Console.WriteLine("here are the current people in Adress Book : ");
                foreach (var person in People)
                {
                    PrintValues(person);
                    
                }

            }
            else
            {
                Console.WriteLine("Address Book is Empty");
            }
        }

        public static void PrintValues(Person person)
        {
            Console.WriteLine($"First Name : {person.firstName}\n");
            Console.WriteLine($"Last Name : {person.lastName}\n");
            Console.WriteLine($"Address : {person.address}\n");
            Console.WriteLine($"City : {person.city}\n");
            Console.WriteLine($"State : {person.state}\n");
            Console.WriteLine($"Zip Code: {person.zipCode}\n");
            Console.WriteLine($"Phone Number: {person.phoneNumber}\n");
            Console.WriteLine($"Email id: {person.email}\n");
        }
    }
}
