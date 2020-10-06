using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class RegeX
    {
        public static string REGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public bool ValidFirstName(string name)
        {
            return Regex.IsMatch(name, REGEX);
        }
    }
}
