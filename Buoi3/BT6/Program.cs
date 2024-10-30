namespace BT6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so n: ");
            int n = int.Parse(Console.ReadLine());
            bool kiemtra = true;

            for (int i = 2; i < n - 1; i++)
            {
                if (n % i == 0)
                {
                   kiemtra = false;
                    break;
                }
            }
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
