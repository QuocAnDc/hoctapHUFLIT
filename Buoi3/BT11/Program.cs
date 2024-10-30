namespace BT11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so n: ");
            int n = int.Parse(Console.ReadLine());

            double tu;
            double mau;
            double sum = 0;
            for (double i  = 1; i <= n; i++)
            {
                tu = 1;
                mau = i;
                sum += tu/mau;
            }
            Console.WriteLine($"tong = {sum}");
        }
    }
}
