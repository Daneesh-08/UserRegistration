using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class UserRegister
    {
        RegeX Obj = new RegeX();
        private string message;
        public UserRegister(string message)
        {
            this.message = message;
        }
        public UserRegister()
        {
        }
        public string FirstName()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successful";
            else
                return "Entry Unsuccessful";
        }
        public string LastName()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successful";
            else
                return "Entry Unsuccessful";
        }
        public string Email()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successful";
            else
                return "Entry Unsuccessful";
        }
        public string MobileNumber()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successful";
            else
                return "Entry Unsuccessful";
        }
        public string Password()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successful";
            else
                return "Entry Unsuccessful";
        }
        public string MultipleEmails(string e1, string e2)
        {
            bool b1 = Obj.ValidEmail(e1);
            bool b2 = Obj.ValidEmail(e2);
            if (b1 && b2)
                return "Entry Successful";
            else
                return "Entry Unsuccessful";
        }
    }
}
