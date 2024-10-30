namespace BT7
{
    internal class Program
    {
        static int tong1denN(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("nhap n = ");
            int n = int.Parse(Console.ReadLine());

            int sum = tong1denN(n);
            Console.WriteLine($"ket qua = {sum}");


        }
    }
}
