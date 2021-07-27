using System;

namespace AdressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Address book problem ");
            AddressBookDetails addressBookDetails = new AddressBookDetails();

            while (true)
            {
                Console.WriteLine("1. Add member to Contact list \n2. View Members in Contact List \n3. Delete members in Contact list \n4. Edit existing contact in List\n5. search a person\n6.View person details by state or city \n7. Exit");
                Console.WriteLine("\nEnter an option:");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        addressBookDetails.AddPerson();
                        break;
                    case 2:
                        addressBookDetails.ListPeople();
                        break;
                    case 3:
                        addressBookDetails.DeleteDetails();
                        break;
                    case 4:
                        addressBookDetails.EditDetails();
                        break;
                    case 5:
                        addressBookDetails.SearchDetails();
                        break;
                    case 6:
                        addressBookDetails.ViewDetails();
                        break;
                    default:
                        Console.WriteLine("exit");
                        return;
                }
            }
        }

    }
}
