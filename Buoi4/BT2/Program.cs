namespace BT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i <= n; i += 2)
            {
                Console.WriteLine($"i = {i*i} ");
            }
        }
    }
}
