namespace BT2
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

            double delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"phuong trinh co 2 nghiem: x1 = {x1}, x2 = {x2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"phuong trinh co nghiem kep: x = {x}");
            }
            else
            {
                Console.WriteLine("phuong trinh vo nghiem");
        }   }
    }
}
