namespace BT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("nhap so n: ");
            n = int.Parse(Console.ReadLine());
            while (n < 1)
            {
                Console.Write("nhap lai n, n > 0: ");
                n = int.Parse(Console.ReadLine());
            }
            for (int i = 2; i <= n; i+=2)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
