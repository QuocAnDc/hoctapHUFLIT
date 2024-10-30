namespace BT12
{
    internal class Program
    {
        static int tinhMu(int a, int n)
        {
            int kq = 1;
            for (int i = 1; i <= n; i++)
            {
                kq *= a;
            }
            return kq;
        }

        static void Main(string[] args)
        {
            Console.Write("nhap a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("nhap n =");
            int n = int.Parse(Console.ReadLine());

            int kq = tinhMu(a,n);
            Console.WriteLine($"kq = {kq}");

        }
    }
}
