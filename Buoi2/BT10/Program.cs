namespace BT10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so n:");
            double n = double.Parse(Console.ReadLine());
            if (n >= 0 && n <= 400.00)
            {
                n = n + n * 0.15;
            }
            else if (n > 400.00 && n <= 800.00)
            {
                n = n + n * 0.12;
            }
            else if (n > 800.00 && n <= 1200.00)
            {
                n = n + n * 0.1;
            }
            else if (n > 1200.00 && n <= 2000.00)
            {
                n = n + n * 0.07;
            }
            else
            {
                n = n + n * 0.04;
            }
            Console.WriteLine($"so luong hien tai la: {n}");

        }
    }
}
