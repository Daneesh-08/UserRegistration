using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class RegeX
    {
        public static string FirstNameREGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string LastNameREGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string EmailREGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public static string MobileNumREGEX = "^[9]{1}[1]{1}[ ]{1}[6-9]{1}[0-9]{9}$";

        public bool ValidFirstName(string name)
        {
            return Regex.IsMatch(name, FirstNameREGEX);
        }
        public bool ValidLastName(string name)
        {
            return Regex.IsMatch(name, LastNameREGEX);
        }
        public bool ValidEmail(string email)
        {
            return Regex.IsMatch(email, EmailREGEX); ;
        }
        public bool ValidMobile(string mobileNumber)
        {
            return Regex.IsMatch(mobileNumber, MobileNumREGEX); ;
        }
    }
}
