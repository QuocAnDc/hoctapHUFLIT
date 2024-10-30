namespace BT11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap toa do x: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("nhap toa do y: ");
            double y = double.Parse(Console.ReadLine());

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Điem nam tai goc toa do.");
            }
            else if (x == 0)
            {
                Console.WriteLine("Điem nam tren truc Oy.");
            }
            else if (y == 0)
            {
                Console.WriteLine("Điem nam tren truc Ox.");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Điem nam o goc phan tu thu nhat (Q1).");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Điem nam o goc phan tu thu hai (Q2).");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Điem nam o goc phan tu thu ba (Q3).");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Điem nam o goc phan tu thu tu (Q4).");
            }
        }
    }
}
