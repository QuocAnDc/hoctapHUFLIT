namespace BT11
{
    internal class Program
    {
        static int Fibbonaci(int n)
        {
            int f1 = 1;
            int f2 = 1;
            int fn = 0;
            if (n <= 0)
            {
                return 0;
            }
            else if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                for (int i = 3; i <= n; i++)
                {
                    fn = f1 + f2;
                    f1 = f2;
                    f2 = fn;   
                }
               
            }
            return fn;
        }

        static void Main(string[] args)
        {
            Console.Write("nhap n = ");
            int n = int.Parse(Console.ReadLine());

            int kq = Fibbonaci(n);
            Console.WriteLine($"kq la: {kq}");udsfoisdufoi
        }
    }
}
