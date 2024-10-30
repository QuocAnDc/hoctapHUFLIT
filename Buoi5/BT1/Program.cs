namespace BT1
{
    internal class Program
    {
        static int cong(int a, int b)
        {
            return a + b;
        }
        static int tru(int a, int b)
        {
            return a - b;
        }
        static int nhan(int a, int b)
        {
            return a * b;
        }
        static double chia(int a, int b)
        {
            double thuong = (double)a / b;
            return thuong;
        }

        static void Main(string[] args)
        {
            Console.Write("nhap a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("nhap b = ");
            int b = int.Parse(Console.ReadLine());

            int tong = cong(a, b);
            Console.WriteLine($"tong = {tong}");
            int hieu = tru(a, b);
            Console.WriteLine($"hieu = {hieu}");
            int tich = nhan(a, b);
            Console.WriteLine($"tich = {tich}");
            double thuong =  chia(a,b);
            Console.WriteLine($"thuong = {thuong}");
        }
    }
}
