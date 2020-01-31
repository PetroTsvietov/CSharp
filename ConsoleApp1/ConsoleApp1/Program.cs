using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu M = new MainMenu();
            M.catalog();
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
    }


