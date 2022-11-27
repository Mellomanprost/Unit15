using System;
using System.Collections.Generic;
using System.Linq;

namespace Unit15._3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", 799900000013, "serg@gmail.com"));
            phoneBook.Add(new Contact("Иннокентий", 799900000013, "innokentii@example.com"));

            #region Мой код

            var phoneByEmail = phoneBook
                .GroupBy(cont => cont.Email.Contains("example"))
                .Select(c => new
                {
                    Email = c.Key,
                    Name = c.Count(),
                    Phones = c.Select(con => con)
                });

            // Выведем результат
            foreach (var group in phoneByEmail)
            {
                if (group.Email)
                {
                    Console.WriteLine("Фейковые аккаунты:");
                    foreach (var phone in group.Phones)
                        Console.WriteLine(phone.Name + " : "  + phone.Email);

                }
                else
                {
                    Console.WriteLine("Настоящие аккаунты:");
                    foreach (var phone in group.Phones)
                        Console.WriteLine(phone.Name + " : " + phone.Email);
                }

                Console.WriteLine();
            }

            #endregion

            #region код SkillFactory

            //  в качестве критерия группировки передаем домен адреса электронной почты
            var grouped = phoneBook.GroupBy(c => c.Email.Split("@").Last());

            // обрабатываем получившиеся группы
            foreach (var group in grouped)
            {
                // если ключ содержит example, значит, это фейк
                if (group.Key.Contains("example"))
                {
                    Console.WriteLine("Фейковые адреса: ");

                    foreach (var contact in group)
                        Console.WriteLine(contact.Name + " " + contact.Email);

                }
                else
                {
                    Console.WriteLine("Реальные адреса: ");
                    foreach (var contact in group)
                        Console.WriteLine(contact.Name + " " + contact.Email);
                }

                Console.WriteLine();
            }

            #endregion
        }
    }
}
