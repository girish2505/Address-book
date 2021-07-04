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
            Console.WriteLine($"Email id: {person.email}");
        }
        public static void EditDetails()
        {
            int f;
            if (People.Count > 0)
            {
                Console.Write("Enter name of a person you want to edit: ");
                string editName = Console.ReadLine();

                foreach (var person in People)
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
                                    Console.WriteLine("First name modified");
                                    break;
                                case 2:
                                    Console.WriteLine("Enter New Last name");
                                    person.lastName = Console.ReadLine();
                                    Console.WriteLine("Last Name Modified");
                                    break;
                                case 3:
                                    Console.WriteLine("Enter New Address");
                                    person.address = Console.ReadLine();
                                    Console.WriteLine("Address mModified");
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
                                    Console.WriteLine("Zip code Modified");
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
                                     Console.WriteLine("Email id  Modified");
                                    break;
                                case 9:
                                    Console.WriteLine("Exited");
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
        public static void DeleteDetails()
        {
            int f = 0;
            if (People.Count > 0)
            {
                Console.Write("Enter name of a person you want to Delete: ");
                string deleteName = Console.ReadLine();

                foreach (var person in People)
                {
                    if (deleteName.ToLower() == person.firstName.ToLower())
                    {
                        Console.WriteLine($"You have deleted {person.firstName} contact");
                        People.Remove(person);
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
