namespace BT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so n:");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine($"{n} là so duong.");
            }
            else if (n < 0)
            {
                Console.WriteLine($"{n} là so am.");
            }
            else
            {
                Console.WriteLine($"{n} là so 0.");
            }
            if (n % 2 == 0)
            {
                Console.WriteLine($"{n} là so chan.");
            }
            else
            {
                Console.WriteLine($"{n} là so le.");
            }
        }
    }
}
