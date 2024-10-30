namespace BT14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            int m = 0;
            if (n < 0)
            {
                Console.WriteLine("nhap n:");
            }
            else if (n > 0 && n < 10)
            {
                Console.WriteLine($"so chai da uong: {n}");
            }
            else
            {
                while(n>=10)
                {
                    m += 10;
                    n = n - 10 + 3;
                }
                m += n;
                Console.WriteLine($"so chai da uong: {m}");
            }
        }
    }
}
