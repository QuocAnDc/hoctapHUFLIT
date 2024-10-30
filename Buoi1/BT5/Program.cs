namespace BT5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("r = ");
            Double r = Double.Parse(Console.ReadLine());
            Double P = 2 * Math.PI * r;
            Console.WriteLine($"P = {P:0.00}");
            Double A = Math.PI * r * r;
            Console.WriteLine($"A = {A:0.00}");

        }
    }
}
