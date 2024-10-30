namespace BT4
{
    internal class Program
    {
        static int Min(int a, int b, int c)
        {
            int min = a;
            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }
            return min;
        }

        static void Main(string[] args)
        {
            Console.Write("nhap a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("nhap b = ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("nhap c = ");
            int c = int.Parse(Console.ReadLine());

            int min = Min(a, b, c);
            Console.WriteLine($"GTNN = {min}");
        }
    }
}
