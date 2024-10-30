namespace BT4
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

            double d;

            if (a > b)
            {
                d = a;
                a = b;
                b = d;
            }

            if (a > c)
            {
                d = a;
                a = c;
                c = d;
            }

            if (b > c)
            {
                d = b;
                b = c;
                c = d;
            }
            Console.WriteLine($"thu tu tang dan cua 3 so la: {a},{b},{c}");
        }
    }
}
