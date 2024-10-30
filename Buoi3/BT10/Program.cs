namespace BT10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int gt = 1;
            Console.Write("nhap so n: ");
            n = int.Parse(Console.ReadLine());
            
            if (n < 0)
            {
                Console.WriteLine("n = 0");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    gt *= i;
                }
                Console.WriteLine($"gia thua cua {n} = {gt}");
            }
        }
    }
}
