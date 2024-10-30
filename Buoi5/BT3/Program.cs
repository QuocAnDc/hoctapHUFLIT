namespace BT3
{
    internal class Program
    {
        static void pheptinh(int a, int b, out int tong, out int hieu, out int tich, out double thuong)
        {
            tong = a + b;
            hieu = a - b;
            tich = a * b;
            thuong =(double) a / b;
        }

        static void Main(string[] args)
        {
            Console.Write("nhap a = ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("nhap b = ");
            int b = int.Parse(Console.ReadLine());

            int tong, hieu, tich;
            double thuong;

            pheptinh(a,b, out tong, out hieu, out tich, out thuong);
            Console.WriteLine($"tong = {tong}");
            Console.WriteLine($"hieu = {hieu}");
            Console.WriteLine($"tich = {tich}");
            Console.WriteLine($"thuong = {thuong}");
        }
    }
}
