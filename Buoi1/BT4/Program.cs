namespace BT4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            Double a = Double.Parse(Console.ReadLine());
            Console.Write("b = ");
            Double b = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Before swapping: a = {a}, b = {b}");
            Double c;
            c = b;
            b = a;
            a = c;
            Console.WriteLine($"After swapping: a = {a}, b = {b}");
        }
    }
}
