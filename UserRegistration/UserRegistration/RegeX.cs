﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class RegeX
    {
        public static string FirstNameREGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string LastNameREGEX = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string EmailREGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}";
        public static string MobileNumREGEX = "^[9]{1}[1]{1}[ ]{1}[6-9]{1}[0-9]{9}$";
        public static string Condition1REGEX = "^[A-Za-z0-9@$!%*#?&]{8,}$";
        public static string Condition2REGEX = "^(?=.*?[A-Z])[A-Za-z0-9@$!%*#?&]{8,}$";
        public static string Condition3REGEX = "^(?=.*?[A-Z])(?=.*?[0-9])[A-Za-z0-9@$!%*#?&]{8,}$";
        public static string Condition4REGEX = "^[A-Za-z0-9]*[@$!%*#?&]{1}[A-Za-z0-9]*$";
        public static string SampleEmailREGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][0-9a-zA-Z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";

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
        public bool ValidCondition1(string password)
        {
            return Regex.IsMatch(password, Condition1REGEX); 
        }

        public bool ValidCondition4(string password)
        {
            return Regex.IsMatch(password, Condition4REGEX); 
        }
        public bool SampleEmail(string email)
        {
            return Regex.IsMatch(email, SampleEmailREGEX);
        }
        public Func<string, bool> isValidFirstName = firstname => Regex.IsMatch(firstname, FirstNameREGEX);
        public Func<string, bool> isValidLastName = lastname => Regex.IsMatch(lastname, LastNameREGEX);
        public Func<string, bool> isValidEmail = email => Regex.IsMatch(email, EmailREGEX);
        public Func<string, bool> isValidMobileNumber = mobilenumber => Regex.IsMatch(mobilenumber, MobileNumREGEX);
        public Func<string, bool> isValidPassword = password => Regex.IsMatch(password, Condition1REGEX) && Regex.IsMatch(password, Condition4REGEX);
    }
}
