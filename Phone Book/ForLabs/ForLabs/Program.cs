using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ForLabs
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook PhoneBook = new PhoneBook();
            PhoneBook.Menu();
        }
    }
    class Person
    {
        public string name;
        public long number;
        public Person(string name, long number)
        {
            this.name = name;
            this.number = number;
        }
    }
    class PhoneBook
    {
        public List<Person> PersonsList = new List<Person>();
        public void Menu()
        {
            Console.WriteLine("1.Check all numbers.\n2.Add number.\n3.Check specific number.");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                CheckAllPerson();
            }
            else if (choice == "2")
            {
                AddPerson();
            }
            else if (choice == "3")
            {
                CheckBySomething();
            }
            else
            {
                Console.WriteLine("You enetred invalid data. Please, follow incstructions.");
            }
        }
        public void AddPerson() 
        {
            Console.WriteLine("Enter a number(12 digits!):");
            string number = Console.ReadLine();

            if (long.TryParse(number, out long Number) == false)
            {             
                Console.WriteLine("Please, enter number only via numbers.");
                AddPerson();
            }
            else if (Number.ToString().Length < 12 || Number.ToString().Length > 12)
            {
                Console.WriteLine("Please, enter 12 digits.");
                AddPerson();
            }else if (PersonsList.Where(s => s.number == Number).Count() != 0)
            {
                Console.WriteLine("Sorry, this number already added");
                AddPerson();
            }
            else
            {
                Console.WriteLine($"Number {Number} is saved. Enter name for this number");
            }
            string name = Console.ReadLine();
            PersonsList.Add(new Person(name, Number));
            Console.WriteLine(PersonsList.Count);
            Console.WriteLine("Number is saved.");
            Menu();
        }
        public void CheckAllPerson()
        {
            for (int i = 0; i < PersonsList.Count; i++)
            {
                Console.WriteLine($"Person with number {i}:");
                Console.WriteLine(PersonsList[i].name);
                Console.WriteLine(PersonsList[i].number + "\n");
            }
            Console.WriteLine("1 - add new number.\n Enter something for back to main menu");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                AddPerson();
            }
            else
            {
                Menu();
            }
        }
        public void CheckBySomething()
        {
            Console.WriteLine("1.Find by number.\n2.Find by name.");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Console.WriteLine("Enter number.");
                string numb = Console.ReadLine();
                if (long.TryParse(numb, out long Numb))
                {
                    var res = PersonsList.Where(s => s.number == Numb).FirstOrDefault();
                    Console.WriteLine("Finded:" + res.name);
                    Console.WriteLine(res.number);               
                }
                else
                {
                    Console.WriteLine("You enetered invalid data. Please follow program's instructions");
                    CheckBySomething();
                }
                Console.WriteLine("1 - Check contact \nSomthing else - Back to main menu.");
                    string Choice = Console.ReadLine();
                if(Choice == "1")
                {
                    CheckBySomething();
                }
                else
                {
                    Menu();
                }
            }
            else if (choice == "2")
            {
                string name = Console.ReadLine();
                var res = PersonsList.Where(s => s.name == name).ToList();
                for (int i = 0; i < res.Count; i++) {
                    Console.WriteLine($"Finded №{i}\n" + res[i].name);
                    Console.WriteLine(res[i].number);
                }
            }
            else
            {
                Console.WriteLine("Please, follow program's instructions.");
                CheckBySomething();
            }
            Console.WriteLine("1 - Check contact \nSomthing else - Back to main menu.");
            string Choice2 = Console.ReadLine();
            if (Choice2 == "1")
            {
                CheckBySomething();
            }
            else
            {
                Menu();
            }
        }
    }
}
