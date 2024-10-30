namespace BT6
{
    internal class Program
    {
        static void MaxMin(int a, int b, int c, out int min, out int max)
        {
            min = a;
            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }

            max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            {
                max = c;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("nhap a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("nhap b = ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("nhap c = ");
            int c = int.Parse(Console.ReadLine());

            int min, max;
            MaxMin(a,b,c, out min, out max);
            Console.WriteLine($"GTLN la : {max}");
            Console.WriteLine($"GTNN la : {min}");
        }
    }
}
