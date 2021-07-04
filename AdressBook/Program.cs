using System;

namespace AdressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Address book problem ");
            AddressBookDetails abd = new AddressBookDetails();

            while (true)
            {
                Console.WriteLine("1. Add member to Contact list \n2. View Members in Contact List \n3. Delete members in Contact list \n4. Edit existing contact in List\n5. Exit");
                Console.WriteLine("\nEnter an option:");
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        abd.AddPerson();
                        break;
                    case 2:
                        abd.ListPeople();
                        break;
                    case 3:
                        abd.DeleteDetails();
                        break;
                    case 4:
                        abd.EditDetails();
                        break;
                    case 5:
                        // to exit from main method
                        return;
                }
            }
        }

    }
}
