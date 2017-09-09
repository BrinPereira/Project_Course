using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Member
    {
        private string firstName = "";
        private string lastName = "";
        private string email = "";

    // default constructor.
        public Member()
        {
        }

    // parametrized constructor.
       public Member(string firstName, string lastName, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }
    
    // get and set for FirstName.
        public string FirstName
        {
            get => firstName;
            set
            {
                if (firstName.Length > 25)
                    throw new ArgumentException("First name should not be more than 25 charachters");
                else
                    firstName = value;
            }
        }

    // get and set for LastName.
        public string LastName
        {
            get => lastName;
            set
            {
                if (lastName.Length > 25)
                    throw new ArgumentException("Last name should not be more than 25 charachters");
                else
                    lastName = value;
            }
        }

    // get and set for email.
        public string Email
        {
            get => email;
            set
            {
                if (email.Length > 25)
                    throw new ArgumentException("Email should not be more than 25 charachters");
                else
                    email = value;
            }
        }

    // method for displaying the details.
        public string GetDisplayText()
        {
            return firstName + " " + lastName + " - " + email + " ";
        }
    }
}