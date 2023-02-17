using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {  string firstname,lastname,middlename,street,state,DOB,country,city,suite,LGA
        ,username,address;
          Console.WriteLine("Enter your first name");
           firstname = Console.ReadLine();
          Console.WriteLine("Enter your middle name");
           middlename = Console.ReadLine();
          Console.WriteLine("Enter your last name");
           lastname = Console.ReadLine();
          Console.WriteLine("Enter your date of birth");
           DOB = Console.ReadLine();
          Console.WriteLine("Enter your street name");
           street = Console.ReadLine();
          Console.WriteLine("Enter your city name");
           city = Console.ReadLine();
          Console.WriteLine("Enter your state name");
           state = Console.ReadLine();
          Console.WriteLine("Enter your country name");
           country = Console.ReadLine();
          Console.WriteLine("Enter your suite name");
           suite = Console.ReadLine();
          Console.WriteLine("Enter your local government area");
           LGA = Console.ReadLine();
            username = $" Fullname: {lastname} {middlename} {firstname}.";
            address = $" Address: {street},{city},{state},{country}.";
           Console.WriteLine(username.ToUpper());
           Console.WriteLine(address);
            
        }
    }
}
