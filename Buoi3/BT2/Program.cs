namespace BT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i += 2)
            {
                Console.WriteLine($"{i} ");
            }
        }
    }
}
