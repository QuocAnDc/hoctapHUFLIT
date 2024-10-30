namespace BT4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
             for (int i = 1; i <= n; i++)
             {
                 for (int k = 1; k <= n - i; k++)
                 {
                     Console.Write(" ");
                 }
                 for (int j = 1; j <= i; j++)
                 {
                     Console.Write("* ");
                 }
                 Console.WriteLine();
             }
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i == n || j == 1 || j == i)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int tong = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{tong} ");
                    tong++;
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                for (int k = 1; k <= n - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i == n || j == 1 || j == i)
                    {
                        Console.Write($"{j} ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
