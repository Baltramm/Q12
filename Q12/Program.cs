using System;
using System.IO;
using System.Collections;
using System.Text;
using System.Collections.Generic;

namespace Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            //  создаём пустой список с типом данных Contact
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", 79990000000, "igor@example.com"));
            phoneBook.Add(new Contact("Андрей", 79990000001, "andrew@example.com"));

            // проверяем, что добавилось в список
            foreach (var contact in phoneBook)
                Console.WriteLine(contact.Name + ": " + contact.PhoneNumber);
        }

        public class Contact // модель класса
        {
            public Contact(string name, long phoneNumber, String email) // метод-конструктор
            {
                Name = name;
                PhoneNumber = phoneNumber;
                Email = email;
            }

            public String Name { get; }
            public long PhoneNumber { get; }
            public String Email { get; }
        }
        private static void AddUnique(Contact newContact, List<Contact> phoneBook)
        {
            bool alreadyExists = false;
            foreach (var contact in phoneBook)
            {
                if (contact.Name == newContact.Name)
                {
                   alreadyExists = true;
                    break;
                }

            }
            if (!alreadyExists)
            {
                phoneBook.Add(newContact);
            }
            phoneBook.Sort((x, y) => String.Compare(x.Name, y.Name, StringComparison.Ordinal));

            foreach (var contact in phoneBook)
                Console.WriteLine(contact.Name + ": " + contact.PhoneNumber);

        }

    }
}