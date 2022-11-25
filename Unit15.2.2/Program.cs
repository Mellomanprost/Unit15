using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading;

namespace Unit15._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
            {
                new Contact() { Name = "Андрей", Phone = 79994500508 },
                new Contact() { Name = "Сергей", Phone = 799990455 },
                new Contact() { Name = "Иван", Phone = 79999675334 },
                new Contact() { Name = "Игорь", Phone = 8884994 },
                new Contact() { Name = "Анна", Phone = 665565656 },
                new Contact() { Name = "Василий", Phone = 3434 }
            };

            var invalidPhones =
                (from contact in contacts
                 let phoneNumber = contact.Phone.ToString()
                 where phoneNumber.Length != 11 || !phoneNumber.StartsWith('7')
                 select contact)
                 .Count();

            Console.WriteLine(invalidPhones);
        }
    }
}
