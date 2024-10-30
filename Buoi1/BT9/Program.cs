namespace BT9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input time (s): ");
            int s = int.Parse(Console.ReadLine());
            int hour = s / 3600;
            int min = s % 3600 / 60;   
            int sec = s % 60;
            Console.WriteLine($"{hour:00}:{min:00}:{sec:00}");

        }
    }
}