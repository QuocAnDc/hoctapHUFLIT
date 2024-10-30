namespace BT7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Working hours = ");
            Double a = Double.Parse(Console.ReadLine());
            Console.Write("Unit price = ");
            Double b = Double.Parse(Console.ReadLine());
            Console.WriteLine($"Your Salary:{a*b} ");

        }
    }
}
