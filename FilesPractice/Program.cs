namespace FilesPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задача 1. Тема 13
            /*Random random = new Random();

            using (var f = File.Create("f"))
            using (var bw = new BinaryWriter(f))
            { 
                for(int i = 0;i < 1000;i++)
                    bw.Write(random.Next(0, 101));
            }

            using (var f = File.OpenRead("f"))
            using (var g = File.Create("g"))
            using (var bw = new BinaryWriter(g))
            using (var br = new BinaryReader(f))
            {
                while (f.Position < f.Length)
                {
                    var number = br.ReadInt32();
                    if (number % 2 == 0)
                    {
                        bw.Write(number);
                        Console.WriteLine(number);  
                    }
                }
            }
            */

            // Задача 4
            Random random = new Random();

            using (var n = File.Create("n"))
            using (var bw = new BinaryWriter(n))
            {
                for (int i = 0; i < 1000; i++)
                    bw.Write(random.Next(0, 101));
            }
            int count = 0;
            List<int> indexIgnore = new List<int>();
            using (var n = File.OpenRead("n"))
            using (var br = new BinaryReader(n))
            {
                for (int i = 0; i < 1000; i++)
                {
                    int number = br.ReadInt32();
                    n.Position = 0;
                    for (int j = 0; j < 1000; j++)
                    {
                        int second = br.ReadInt32();
                        if (!indexIgnore.Contains(i) &&
                            !indexIgnore.Contains(j) &&
                            number == -second)
                        {
                            indexIgnore.Add(j);
                            indexIgnore.Add(i);
                            count++;
                            break;
                        }
                    }
                    n.Seek((i + 1) * 4, SeekOrigin.Begin);
                }
            }

            Console.WriteLine(count);
        }
    }
}