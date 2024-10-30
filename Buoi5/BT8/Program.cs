namespace BT8
{
    internal class Program
    {
        static int tongcacso(int n)
        {
            int sodu = 0;
            int sum = 0;
            while (n>0)
            {
                sodu = n % 10;
                sum += sodu;
                n /= 10;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("nhap n = ");
            int n = int.Parse(Console.ReadLine());

            int tong = 0;
            tong = tongcacso(n);
            Console.WriteLine($"tong la : {tong}");
        }
    }
}
