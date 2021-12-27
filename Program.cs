using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
// Ability to create a Contacts in Address Book with first and last names,
// address,city, state, zip, phone number andemail...

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string email { get; set; }
    public double phone { get; set; }
    public double zip { get; set; }
}


class Program
{
    public static List<Person> People = new List<Person>();
    static void Main(string[] args)
    {
        Console.WriteLine("__________AddressBookProgram____________");
        int choice = 0;
        while (choice != 4)
        {
            Console.WriteLine("Enter your choice: 1. AddContact 2.ContactList 3..Update contact 4.Exit");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    AddPerson();
                    break;
                case 2:
                    ListPeople();
                    break;
                case 3:
                    UpdatePeople();
                    break;
            }
        }

    }
    private static void AddPerson()
    {
        Person person = new Person();

        Console.Write("Enter First Name: ");
        person.FirstName = Console.ReadLine();

        Console.Write("Enter Last Name: ");
        person.LastName = Console.ReadLine();

        Console.Write("Enter Address: ");
        person.Address = Console.ReadLine();

        Console.Write("Enter City: ");
        person.City = Console.ReadLine();

        Console.Write("Enter State: ");
        person.State = Console.ReadLine();

        Console.Write("Enter email: ");
        person.email = Console.ReadLine();

        Console.Write("Enter Phone Number: ");
        person.phone = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Zip Code: ");
        person.zip = Convert.ToDouble(Console.ReadLine());

        People.Add(person);
    }
    private static void PrintPerson(Person person)
    {
        Console.WriteLine("First Name: " + person.FirstName);
        Console.WriteLine("Last Name: " + person.LastName);
        Console.WriteLine("Address: " + person.Address);
        Console.WriteLine("City: " + person.City);
        Console.WriteLine("State: " + person.State);
        Console.WriteLine("Email: " + person.email);
        Console.WriteLine("Phone Number: " + person.phone);
        Console.WriteLine("Zip Code: " + person.zip);
        Console.WriteLine("-------------------------------------------");
    }

    private static void ListPeople()
    {
        if (People.Count == 0)
        {
            Console.WriteLine("Your address book is empty. Press any key to continue.");
            Console.ReadKey();
            return;
        }
        Console.WriteLine("Here are the current people in your address book:\n");
        foreach (var person in People)
        {
            PrintPerson(person);
        }
        Console.WriteLine("\nPress any key to continue.");
        Console.ReadKey();
    }


    private static void UpdatePeople()
    {
        Console.WriteLine("Enter the first name of the person you would like to Update.");
        string firstName = Console.ReadLine();
        Person person = People.FirstOrDefault(x => x.FirstName.ToLower() == firstName.ToLower());
        if (person == null)
        {
            Console.WriteLine("That person could not be found. Press any key to continue");
            Console.ReadKey();
            return;
        }
        else
        {
            Console.WriteLine("__________Update____________");
            int option = 0;
            while (option != 9)
            {
                Console.WriteLine("Enter your choice that yoy want to update:\n" +
                    " 1. Fistname\n " +
                    "2.Last Name \n" +
                    "3.Address \n" +
                    "4.City \n" +
                    "5.State \n" +
                    "6.email \n" +
                    "7.Phone Number \n" +
                    "8. Zip COde \n" +
                    "9. Exit \n");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Update FirstNme: ");
                        var result = from r in People where r.FirstName.ToLower() == firstName.ToLower() select r;
                        result.First().FirstName = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Update LastNme: ");
                        result = from r in People where r.LastName == person.LastName select r;
                        result.First().LastName = Console.ReadLine();
                        break;
                    case 3:
                        Console.Write("update Address:");
                        result = from r in People where r.Address == person.Address select r;
                        result.First().Address = Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Update City: ");
                        result = from r in People where r.City == person.City select r;
                        result.First().City = Console.ReadLine();
                        break;
                    case 5:
                        Console.Write("Update State: ");
                        result = from r in People where r.State == person.State select r;
                        result.First().State = Console.ReadLine();
                        break;
                    case 6:
                        Console.Write("Update email: ");
                        result = from r in People where r.email == person.email select r;
                        result.First().email = Console.ReadLine();
                        break;
                    case 7:
                        Console.Write("Update Phone: ");
                        result = from r in People where r.phone == person.phone select r;
                        result.First().phone = Convert.ToDouble(Console.ReadLine());
                        break;
                    case 8:
                        Console.Write("update Zip: ");
                        result = from r in People where r.zip == person.zip select r;
                        result.First().zip = Convert.ToDouble(Console.ReadLine());
                        break;
                }
            }

        }
    }
}