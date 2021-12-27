using System;
// Ability to create a Contacts in Address Book with first and last names,
// address,city, state, zip, phone number andemail...

class AddressBookMain
{
    public string firstName, lastName, address, city, state, email;
    public double phone, zip;

    public AddressBookMain(string a, string b, string c, string d, string e, string f, double ph, double z)
    {
        this.firstName = a;
        this.lastName = b;
        this.address = c;
        this.city = d;
        this.state = e;
        this.email = f;
        this.phone = ph;
        this.zip = z;

    }
    public void Display()
    {
        Console.WriteLine();
        Console.WriteLine("==============AddressBook===============");
        Console.WriteLine("Name : " + firstName + " " + lastName);
        Console.WriteLine("Address : " + address);
        Console.WriteLine("\t  " + city);
        Console.WriteLine("\t  " + state);
        Console.WriteLine("Email : " + email);
        Console.WriteLine("Mobile : " + phone);
        Console.WriteLine("Zip_Code : " + zip);
    }
}


class Program
{
    static void Main(string[] args)
    {
        AddressBookMain res = new AddressBookMain("svc", "Bhuma",
            "podili", "Ongole", "va", "suvarchala12@gmail.com",
            7981267755, 523240);
        res.Display();
    }
}