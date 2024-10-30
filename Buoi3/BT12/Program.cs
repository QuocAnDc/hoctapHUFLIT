namespace BT12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tu;
            double mau;
            double sum = 0;
            for (double i = 1; 2 * i - 1 <= 39; i++)
            {
                tu = 2 * i -1;
                mau = Math.Pow(2,i-1);
                sum += tu / mau;
            }
            Console.WriteLine($"tong = {sum}");
        }
    }
}
