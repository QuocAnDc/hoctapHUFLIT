namespace BT5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("nhap so b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("nhap so c: ");
            double c = double.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                double chuvi = a + b + c;
                Console.WriteLine($"chu vi hinh tam giac la: {chuvi}");
            }
            else
            {
                double dientich = ((a + b) * c) / 2;
                Console.WriteLine($"dien tich cua hinh thang la: {dientich}");
            }
        }
    }
}
