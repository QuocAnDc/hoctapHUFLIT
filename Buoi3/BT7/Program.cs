namespace BT7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; (sum+i) < 200000; i++)
            {
                sum += i;
            }
            Console.WriteLine($"tong = {sum}");
        }
    }
}
