namespace BT13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i,-2} x {"1",-2} = {i*1,-2} |");
            }
            Console.WriteLine();
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i,-2} x {"2",-2} = {i * 2,-2} |");
            }
            Console.WriteLine();
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{i,-2} x {"3",-2} = {i * 3,-2} |");
            }
        }
    }
}
