namespace BT2
{
    internal class Program
    {
        static void hoandoi(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
        }

        static void Main(string[] args)
        {
            Console.Write("nhap a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("nhap b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"truoc khi hoan doi a = {a}, b = {b}");
            hoandoi(ref a, ref b);
            Console.WriteLine($"sau khi hoan doi a = {a}, b = {b}");
        }
    }
}
