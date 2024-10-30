namespace BT5
{
    internal class Program
    {
        static int Max(int a, int b, int c)
        {
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
            return max;
        }

        static void Main(string[] args)
        {
            Console.Write("nhap a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("nhap b = ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("nhap c = ");
            int c = int.Parse(Console.ReadLine());

            int max = Max(a, b, c);
            Console.WriteLine($"GTLN = {max}");
        }
    }
}
