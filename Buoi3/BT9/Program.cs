using System;
using System.Threading.Channels;

namespace BT9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("nhap so n: ");
            n = int.Parse(Console.ReadLine());
            while(!(n >= 100 && n <= 500 && n % 2 ==0))
            {
                Console.Write("nhap lai n: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"ban da nhap dung so {n}");
        }
    }
}
