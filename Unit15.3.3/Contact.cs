using System;
using System.Collections.Generic;
using System.Text;

namespace Unit15._3._3
{
    public class Contact
    {
        public string Name;
        public long PhoneNumber;
        public string Email;

        public Contact(string name, long phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
