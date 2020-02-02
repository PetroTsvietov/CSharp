using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<user> users = new List<user>();
            user u = new user("login", "password");
            string path = @"D:\HLAM\BD.txt";

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                int i = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    i++;
                }
                for (int v = 0; v <= i; v++)
                {
                    if (i % 2 == 0)
                    {
                        line = u.password;
                        users.Add(new user(u.login, u.password));
                    }
                    else
                    {
                        line = u.login;
                        users.Add(new user(u.login, u.password));
                    }
                }
            }
            account a = new account();
            a.autorization("login2", "password2");
        }
    }
    class ConsoleHelper
    {
        public static void WriteMessage(string input)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(input);
        }
    }
    class MainMenu
    {
        public void summa(int a)
        {
            string writePath = @"D:\HLAM\sum.txt";

            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.UTF8))
                {
                    sw.WriteLine(a);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void catalog()
        {
            wallet h = new wallet();
            ConsoleHelper.WriteMessage(@"Приветствуем вас в нашем магазине. Ваш баланс:" + h.count + ".\nВыберите категорию товара.\n1.Фрукты\n2.Овощи\n3.Черыны самотыки\n4.Карзина\nВведите номер категории:");
            int choice = Convert.ToInt32(Console.ReadLine());
            string[] fruits = { "Бананы", "Яблоки", "Абрикосы", "Апельсины" };
            string[] vegetables = { "Огурцы", "Помидоры", "Твоя мамка", "Брокколи" };
            string[] samotiki = { "Разрушитель", "Ласкатель", "Геракл", "Ахиллес" };
            if (choice == 1)
            {
                string path = @"D:\HLAM\fruits.txt";

                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                int choice2 = Convert.ToInt32(Console.ReadLine());
                if (choice2 == 1)
                {
                    string writePath = @"D:\HLAM\basket.txt";


                    try
                    {
                        using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine(fruits[0]);
                        }
                        Console.WriteLine("Добавлено в карзину");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    summa(10);
                    catalog();
                }
                if (choice2 == 2)
                {
                    string writePath = @"D:\HLAM\basket.txt";
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine(fruits[1]);
                        }
                        Console.WriteLine("Добавлено в карзину");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    summa(8);
                    catalog();
                }
                if (choice2 == 3)
                {
                    string writePath = @"D:\HLAM\basket.txt";
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine(fruits[2]);
                        }
                        Console.WriteLine("Добавлено в карзину");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    summa(5);
                    catalog();
                }
                if (choice2 == 4)
                {
                    string writePath = @"D:\HLAM\basket.txt";
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine(fruits[3]);
                        }
                        Console.WriteLine("Добавлено в карзину");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    summa(12);
                    catalog();
                }
                if (choice2 == 5)
                {
                    catalog();
                }
            }
            else if (choice == 2)
            {
                string path = @"D:\HLAM\vegetables.txt";

                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                int choice2 = Convert.ToInt32(Console.ReadLine());
                if (choice2 == 1)
                {
                    string writePath = @"D:\HLAM\basket.txt";


                    try
                    {
                        using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine(vegetables[0]);
                        }
                        Console.WriteLine("Добавлено в карзину");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    summa(20);
                    catalog();
                }
                if (choice2 == 2)
                {
                    string writePath = @"D:\HLAM\basket.txt";
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine(vegetables[1]);
                        }
                        Console.WriteLine("Добавлено в карзину");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    summa(15);
                    catalog();
                }
                if (choice2 == 3)
                {
                    string writePath = @"D:\HLAM\basket.txt";
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine(vegetables[2]);
                        }
                        Console.WriteLine("Добавлено в карзину");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    summa(1);
                    catalog();
                }
                if (choice2 == 4)
                {
                    string writePath = @"D:\HLAM\basket.txt";
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine(vegetables[3]);
                        }
                        Console.WriteLine("Добавлено в карзину");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    summa(30);
                    catalog();
                }
                if (choice2 == 5)
                {
                    catalog();
                }
            }
            else if (choice == 3)
            {
                string path = @"D:\HLAM\samotiki.txt";

                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                int choice2 = Convert.ToInt32(Console.ReadLine());
                if (choice2 == 1)
                {
                    string writePath = @"D:\HLAM\basket.txt";


                    try
                    {
                        using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine(samotiki[0]);
                        }
                        Console.WriteLine("Добавлено в карзину");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    summa(50);
                    catalog();
                }
                if (choice2 == 2)
                {
                    string writePath = @"D:\HLAM\basket.txt";
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine(samotiki[1]);
                        }
                        Console.WriteLine("Добавлено в карзину");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    summa(100);
                    catalog();
                }
                if (choice2 == 3)
                {
                    string writePath = @"D:\HLAM\basket.txt";
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine(samotiki[2]);
                        }
                        Console.WriteLine("Добавлено в карзину");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    summa(75);
                    catalog();
                }
                if (choice2 == 4)
                {
                    string writePath = @"D:\HLAM\basket.txt";
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.UTF8))
                        {
                            sw.WriteLine(samotiki[3]);
                        }
                        Console.WriteLine("Добавлено в карзину");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    summa(1000);
                    catalog();
                }
                if (choice2 == 5)
                {
                    catalog();
                }
            }
            else if (choice == 4)
            {
                string pather = @"D:\HLAM\basket.txt";

                try
                {
                    using (StreamReader sr = new StreamReader(pather))
                    {
                        Console.WriteLine(sr.ReadToEnd());
                    }
                    int choice2 = Convert.ToInt32(Console.ReadLine());
                    if (choice2 == 1)
                    {
                        catalog();
                    }
                    if (choice2 == 2)
                    {
                        File.WriteAllText(@"D:\HLAM\basket.txt", string.Empty);
                        File.WriteAllText(@"D:\HLAM\sum.txt", string.Empty);
                        catalog();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
    class wallet        //кошелек нахуй
    {
        public int count = 1000;//стандарт нахуй
    }
    class user
    {
        public string login, password;
        public user(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
    }
    class account
    {
        user u = new user("login", "password");
        public string login2;
        public string password2;
        public string registration;
        public string new_login;
        public string new_password;
        public string re_new_password;
        MainMenu M = new MainMenu();
        public void autorization(string login2, string password2)
        {
            
            ConsoleHelper.WriteMessage("Желаете ли вы зарегистрироватся?\n1.Да\n2.Нет");
            registration = Console.ReadLine();
            if (registration == "1")
            {
                regist("new_login", "new_password");
            }
            ConsoleHelper.WriteMessage("Логин:");
            login2 = Console.ReadLine();
            ConsoleHelper.WriteMessage("Пароль:");
            password2 = Console.ReadLine();
            if (Valid(new_login, login2, password2) == true)
            {
                M.catalog();
            }
            else if(Valid(new_login, login2, password2) == false)
            {
                ConsoleHelper.WriteMessage("Пароль или логин введены неправильно. Попробуйте еще раз.");
                autorization("login2", "password2");
            }
        }
        List<user> users = new List<user>();
        public void regist(string new_login, string new_password)
        {
            string writePath = @"D:\HLAM\BD.txt";
            ConsoleHelper.WriteMessage("Здравствуйте! Вы зашли на регистрацию.\nВведите ваш логин:");
            new_login = Console.ReadLine();
            if (Valid(new_login, login2, password2) == true)
            {   
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(new_login);
                }
            }
            else if(Valid(new_login, login2, password2) == false)
            {
                ConsoleHelper.WriteMessage("Ошибка! Такой логин уже зарегистрирован");
                regist("new_login", "new_password");
            }
            ConsoleHelper.WriteMessage("Ваш пароль:");
            new_password = Console.ReadLine();
            writePath = @"D:\HLAM\BD.txt";
            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine(new_password);
            }
            ConsoleHelper.WriteMessage("Повторите Ваш пароль:");
            re_new_password = Console.ReadLine();
            if (re_new_password != new_password)
            {
                ConsoleHelper.WriteMessage("Вы ввели повторный пароль неправильно.");
                regist("new_login", "new_password");
            }
            else
            {
                ConsoleHelper.WriteMessage("Поздравляем с регистрацией!");
                string path = @"D:\HLAM\BD.txt";

                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    int i = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        i++;
                    }
                    for (int a = 0; a <= i; a++)
                    {
                        if(i%2 == 0)
                        {
                            line = u.password;
                            users.Add(new user(u.login, u.password));
                        }
                        else
                        {
                            line = u.login;
                            users.Add(new user(u.login, u.password));
                        }
                    }
                }
                
            }
        }

        public bool Valid(string b, string c, string d)
        {
            for(int a =0; a < users.Count; a++) {
                if (b == u.login)
                {
                    return false;
                } else if (c != u.login || d != u.password)
                {
                    return false;

                }
                else
                {
                    return true;
                }
            }
            return false;
        }
    }
}


