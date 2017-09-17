using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_New
{
   public class Member : ObservableObject
    {
        private string firstName = "";
        private string lastName = "";
        private string email = "";
        private String getDisplayText = "";
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
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length > 25)
                    Messenger.Default.Send(new NotificationMessage("First name should not be more than 25 charachters"));
                else
                 Set<string>(() => this.FirstName, ref firstName, value);
            }
        }

        // get and set for LastName.
        public string LastName
        {
            get => lastName;
            set
            {
                if (value.Length > 25)
                    Messenger.Default.Send(new NotificationMessage("Last name should not be more than 25 charachters"));
                else
                    Set<string>(() => this.LastName, ref lastName, value);
            }
        }

        // get and set for email.
        public string Email
        {
            get => email;
            set
            {
                if (value.Length > 25)
                    Messenger.Default.Send(new NotificationMessage("Email should not be more than 25 charachters"));
                else
                    Set<string>(() => this.Email, ref email, value);
            }
        }

        // display the values
        public string GetDisplayText
             {

            get
            {
                return FirstName + " " + LastName + " - " + Email + " ";

            }
            set => getDisplayText = value; }
    }
}
