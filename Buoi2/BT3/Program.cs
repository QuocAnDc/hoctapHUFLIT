namespace BT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("nhap so b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("nhap so c: ");
            double c = double.Parse(Console.ReadLine());

            double max = a;

            if (b > max)
            {
                max = b;
            }

            if (c > max)
            {
                max = c;
            }
            Console.WriteLine($"gia tri lon nhat la: {max}");
        }
    }
}
