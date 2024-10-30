namespace BT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap n = ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            if (sum == n)
            {
                Console.WriteLine($"{n} la so hoan hao");
            }
            else
            {
                Console.WriteLine($"{n} la so khong hoan hao");
            }
        }
    }
}
