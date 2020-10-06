using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name :");
            string firstname = Console.ReadLine();
            RegeX regex = new RegeX();
            if (regex.ValidFirstName(firstname))
                Console.WriteLine("First Name is VALID !!");
            else
                Console.WriteLine("First Name is INVALID !!");
            Console.WriteLine("Enter Last Name :");
            string lastname = Console.ReadLine();
            if (regex.ValidLastName(lastname))
                Console.WriteLine("Last Name is VALID !!");
            else
                Console.WriteLine("Last Name is INVALID !!");
            Console.WriteLine("Enter Email :");
            string email = Console.ReadLine();
            if (regex.ValidEmail(email))
                Console.WriteLine("Email is VALID !!");
            else
                Console.WriteLine("Email is INVALID !!");
            Console.WriteLine("Enter Mobile Number :");
            string mobilenum = Console.ReadLine();
            if (regex.ValidMobile(mobilenum))
                Console.WriteLine("Mobile Number is VALID !!");
            else
                Console.WriteLine("Mobile Number is INVALID !!");
            Console.WriteLine("Enter Password :");
            string Rule4 = Console.ReadLine();
            if (regex.ValidCondition4(Rule4))
                Console.WriteLine("Password is VALID !!");
            else
                Console.WriteLine("Password is INVALID !!");
        }
    }
}
