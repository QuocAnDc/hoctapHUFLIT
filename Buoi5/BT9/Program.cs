namespace BT9
{
    internal class Program
    {
        static int solonnhat(int n)
        {
            int sodu = 0;
            int max = 0;
            while (n > 0)
            {
                sodu = n % 10;
                if (sodu > max)
                {
                    max = sodu;
                }
                n /= 10;
            }
            return max;
        }
        static void Main(string[] args)
        {
            Console.Write("nhap n = ");
            int n = int.Parse(Console.ReadLine());

            int Max = solonnhat(n);
            Console.WriteLine($"Max = {Max}");
        }
    }
}
