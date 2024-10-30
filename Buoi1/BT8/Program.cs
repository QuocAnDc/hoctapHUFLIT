using System.Data;

namespace BT8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Amount of money: ");
            int n = int.Parse(Console.ReadLine());
            int to100 = n / 100;
            Console.WriteLine($"tờ 100: {to100}");
            n = n % 100;
            int to50 =  n / 50;
            Console.WriteLine($"tờ 50: {to50}");
            n = n % 50;
            int to20 = n / 20;
            Console.WriteLine($"tờ 20: {to20}");
            n = n % 20;
            int to10 = n / 10;
            Console.WriteLine($"tờ 10: {to10}");
            n = n % 10;
            int to5 = n / 5;
            Console.WriteLine($"tờ 5: {to5}");
            n = n % 5;
            int to2 = n / 2;
            Console.WriteLine($"tờ 2: {to2}");
            n = n % 2;
            int to1 = n / 1;
            Console.WriteLine($"tờ 1: {to1}");
        }
    }
}
