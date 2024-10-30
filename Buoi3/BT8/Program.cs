namespace BT8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so n: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; (sum + i) < n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"tong = {sum}");
        }
    }
}
