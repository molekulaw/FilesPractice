using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace FilesPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 1. Тема 13
            //Random random = new Random();

            //using (var f = File.Create("f"))
            //using (var bw = new BinaryWriter(f))
            //{
            //    for (int i = 0; i < 1000; i++)
            //        bw.Write(random.Next(0, 101));
            //}

            //using (var f = File.OpenRead("f"))
            //using (var g = File.Create("g"))
            //using (var bw = new BinaryWriter(g))
            //using (var br = new BinaryReader(f))
            //{
            //    while (f.Position < f.Length)
            //    {
            //        var number = br.ReadInt32();
            //        if (number % 2 == 0)
            //        {
            //            bw.Write(number);
            //            Console.WriteLine(number);  
            //        }
            //    }
            //}





            // задача 2


            //Random random = new Random();

            //double proizved = 1;
            //using (var n = File.Create("n"))
            //using (var bw = new BinaryWriter(n))
            //{
            //    for (int i = 0; i < 100; i++)
            //        bw.Write(random.NextDouble() + random.Next(0, 10));
            //}
            //using (var f = File.OpenRead("n"))
            //using (var br = new BinaryReader(f))
            //    while (f.Position < f.Length)
            //    { 
            //    double a = br.ReadDouble();
            //        proizved *= a;
            //        Console.WriteLine(a);
            //    }
            //Console.WriteLine(proizved);

            // задача 3

            //Console.WriteLine("Числа файла будут делиться на число...");
            //int.TryParse(Console.ReadLine(), out int m);
            //Console.WriteLine("И не будут делиться на число...");
            //int.TryParse(Console.ReadLine(), out int n);

            //Random random = new Random();

            //using (var f = File.Create("f"))
            //using (var bw = new BinaryWriter(f))

            //{
            //    for (int i = 0; i < 1000; i++)
            //        bw.Write(random.Next(0, 101));
            //}
            //using (var f = File.OpenRead("f"))
            //using (var br = new BinaryReader(f))
            //using (var g = File.Create("g"))
            //using (var bw = new BinaryWriter(g))
            //    while (f.Position < f.Length)
            //    {
            //        int a = br.ReadInt32();

            //        if (a % m == 0 && a % n != 0)
            //        { 
            //            bw.Write(a);
            //            Console.WriteLine(a);
            //        }
            //    }


            // Задача 4
            //    Random random = new Random();

            //    using (var n = File.Create("n"))
            //    using (var bw = new BinaryWriter(n))
            //    {
            //        for (int i = 0; i < 1000; i++)
            //            bw.Write(random.Next(0, 101));
            //    }
            //    int count = 0;
            //    List<int> indexIgnore = new List<int>();
            //    using (var n = File.OpenRead("n"))
            //    using (var br = new BinaryReader(n))
            //    {
            //        for (int i = 0; i < 1000; i++)
            //        {
            //            int number = br.ReadInt32();
            //            n.Position = 0;
            //            for (int j = 0; j < 1000; j++)
            //            {
            //                int second = br.ReadInt32();
            //                if (!indexIgnore.Contains(i) &&
            //                    !indexIgnore.Contains(j) &&
            //                    number == -second)
            //                {
            //                    indexIgnore.Add(j);
            //                    indexIgnore.Add(i);
            //                    count++;
            //                    break;
            //                }
            //            }
            //            n.Seek((i + 1) * 4, SeekOrigin.Begin);
            //        }
            //    }

            //    Console.WriteLine(count);

            // задача 5

            //List<int> povtor = new List<int>();
            //Random random = new Random();

            //using (var f = File.Create("f"))
            //using (var bw = new BinaryWriter(f))
            //{
            //    for (int i = 0; i < 1000; i++)
            //        bw.Write(random.Next(0, 101));
            //}
            //using (var f = File.OpenRead("f"))
            //using (var br = new BinaryReader(f))
            //using (var g = File.Create("g"))
            //using (var bw = new BinaryWriter(g))
            //    while (f.Position < f.Length)
            //    {
            //        int number = br.ReadInt32();
            //        if (!povtor.Contains(number))
            //        {
            //            povtor.Add(number);
            //            break; 
            //        }
            //        Console.WriteLine(g); 
            //    }


            // задача 6
            //Console.WriteLine("Введите число, которое будет кратным числам в файле:");
            //int.TryParse(Console.ReadLine(), out int k);

            //Random random = new Random();

            //using (var n = File.Create("n"))
            //using (var bw = new BinaryWriter(n))
            //{
            //    for (int i = 0; i < 100; i++)
            //        bw.Write(random.NextDouble() + random.Next(0, 10));
            //}
            //using (var n = File.OpenRead("n"))
            //using (var br = new BinaryReader(n))
            //using (var g = File.Create("g"))
            //using (var bw = new BinaryWriter(g))
            //    while (n.Position < n.Length)
            //    { 
            //        int number = br.ReadInt32();
            //        if (number % k == 0)
            //        {
            //            bw.Write(number);
            //        }
            //        Console.WriteLine(g);
            //    }



            // задача 7

            //int min = int.MaxValue;
            //int max = int.MinValue;

            //Random random = new Random();

            //using (var n = File.Create("n"))
            //using (var bw = new BinaryWriter(n))
            //{
            //    for (int i = 0; i < 100; i++)
            //        bw.Write(random.NextDouble() + random.Next(0, 10));
            //}
            //using (var n = File.OpenRead("n"))
            //using (var br = new BinaryReader(n))
            //    while (n.Position < n.Length)
            //    {
            //        int number = br.ReadInt32();

            //        if (number < min)
            //        {
            //            min = number;
            //        }
            //        if (number > max)
            //        { 
            //            max = number;
            //        } 
            //    }
            //int summ = min + max;
            //Console.WriteLine(summ);



            // задача 8

            //Console.WriteLine("Сколько чисел в файле?");
            //int.TryParse(Console.ReadLine(), out int quantity);
            //Random random = new Random();

            //using (var n = File.Create("n"))
            //using (var bw = new BinaryWriter(n))
            //{
            //    for (int i = 0; i < quantity; i++)
            //        bw.Write(random.NextDouble() + random.Next(0, 10));
            //}
            //int proizved = 1;
            //using (var n = File.OpenRead("n"))
            //using (var br = new BinaryReader(n))
            //using (var g = File.Create("g"))
            //using (var bw = new BinaryWriter(g))
            //    while (n.Position < n.Length)
            //    { 
            //        int number = br.ReadInt32();
            //            proizved *= number;
            //            bw.Write(proizved);
            //        Console.WriteLine(proizved);
            //}



            // задача 9

            //Random random = new Random();

            //using (var n = File.Create("n"))
            //using (var bw = new BinaryWriter(n))
            //{
            //    for (int i = 0; i < 100; i++)
            //        bw.Write(random.NextDouble() + random.Next(0, 10));
            //}
            //using (var n = File.OpenRead("n"))
            //using (var br = new BinaryReader(n))
            //using (var g = File.Create("g"))
            //using (var bw = new BinaryWriter(g))
            //    while (n.Position < n.Length)
            //    {
            //        int number = br.ReadInt32();
            //        if (number % K != 0)
            //        {
            //            bw.Write(number);
            //        }
            //        Console.WriteLine(g);
            //    }


            // задача 10

            //int count = 0;
            //Random random = new Random();

            //using (var f = File.Create("f"))
            //using (var bw = new BinaryWriter(f))
            //{
            //    for (int i = 0; i < 100; i++)
            //        bw.Write(random.NextDouble() + random.Next(0, 10));
            //}
            //using (var f = File.OpenRead("f"))
            //using (var br = new BinaryReader(f))
            //using (var g = File.Create("g"))
            //using (var bw = new BinaryWriter(g))
            //    while (f.Position < f.Length)
            //    { 
            //        int number = br.ReadInt32();
            //        int nechet = number / 2;
            //        if (nechet % 2 != 0)
            //        { 
            //            bw.Write(number);
            //            count++;
            //        }
            //        Console.WriteLine($"Кол-во удвоенных нечетных чисел: {count}");
            //    }


            // задача 11

            //int count = 0;
            //Random random = new Random();

            //using (var f = File.Create("f"))
            //using (var bw = new BinaryWriter(f))
            //{
            //    for (int i = 0; i < 100; i++)
            //        bw.Write(random.NextDouble() + random.Next(0, 10));
            //}
            //using (var f = File.OpenRead("f"))
            //using (var br = new BinaryReader(f))
            //using (var g = File.Create("g"))
            //using (var bw = new BinaryWriter(g))
            //    while (f.Position < f.Length)
            //    {
            //        int number = br.ReadInt32();
            //        double nechet = Math.Sqrt(number);
            //        if (nechet % 2 != 0)
            //        {
            //            bw.Write(number);
            //            count++;
            //        }
            //        Console.WriteLine($"Кол-во удвоенных нечетных чисел: {count}");
            //    }



            // задача 12

            //int max = int.MinValue;
            //int j = 1;

            //Random random = new Random();

            //using (var f = File.Create("f"))
            //using (var bw = new BinaryWriter(f))
            //{
            //    for (int i = 0; i < 100; i++)
            //        bw.Write(random.NextDouble() + random.Next(0, 10));
            //}
            //using (var f = File.OpenRead("f"))
            //using (var br = new BinaryReader(f))
            //using (var g = File.Create("g"))
            //using (var bw = new BinaryWriter(g))
            //    while (f.Position < f.Length)
            //    {
            //        int number = br.ReadInt32();
            //        if (j % 2 == 0)
            //        { 
            //            bw.Write(number);
            //            if (number > max)
            //            {
            //                max = number;
            //            }
            //        }
            //        j++;
            //        Console.WriteLine($"Самое наибольшее из нечетных чисел: {number}");
            //    }
        }
    }
}