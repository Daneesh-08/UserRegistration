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
        public bool ValidFirstName(string name)
        {
            return Regex.IsMatch(name, FirstNameREGEX);
        }
        public bool ValidLastName(string name)
        {
            return Regex.IsMatch(name, LastNameREGEX);
        }
    }
}
