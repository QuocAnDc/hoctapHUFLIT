namespace BT10
{
    internal class Program
    {
        static bool ktsonguyento(int n)
        {
            bool kiemtra = true;

            for (int i = 2; i < n - 1; i++)
            {
                if (n % i == 0)
                {
                    kiemtra = false;
                    break;
                }
            }
            return kiemtra;
        }
        static void Main(string[] args)
        {
            Console.Write("nhap n = ");
            int n = int.Parse(Console.ReadLine());
            bool kiemtra = ktsonguyento(n);
            if (kiemtra == true)
            {
                Console.WriteLine($"{n} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"{n} khong phai la so nguyen to");
            }
        }
    }
}
