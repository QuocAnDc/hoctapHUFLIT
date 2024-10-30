namespace BT4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            double Age = 0;
            Age = (double) sum / n;
            Console.WriteLine($"tong = {sum}");
            Console.WriteLine($"trung binh cong = {Age}");
        }
    }
}
