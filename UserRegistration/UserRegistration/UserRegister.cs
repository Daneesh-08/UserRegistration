using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistration
{
    public class UserRegister
    {
        private string message;
        public UserRegister(string message)
        {
            this.message = message;
        }
        public string FirstName()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successfull";
            else
                return "Entry UnSuccessfull";
        }
        public string LastName()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successfull";
            else
                return "Entry UnSuccessfull";
        }
        public string Email()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successfull";
            else
                return "Entry UnSuccessfull";
        }
        public string MobileNumber()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successfull";
            else
                return "Entry UnSuccessfull";
        }
        public string Password()
        {
            if (this.message.Contains("Happy"))
                return "Entry Successfull";
            else
                return "Entry UnSuccessfull";
        }
    }
}
