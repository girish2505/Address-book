using System;

namespace AdressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Address book problem ");

            while (true)
            {
                Console.WriteLine("1. Add member to Contact list \n2.View Members in Contact List\n3.Exit");
                Console.WriteLine("\nEnter an option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        AddressBookDetails.AddPerson();
                        break;
                    case 2:
                        AddressBookDetails.ListPeople();
                        break;
                    case 3:
                        // to exit from main method
                        return;
                }
            }
        }

    }
}
