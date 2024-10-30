namespace BT8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so x cho biet x thuoc doan:");
            int x = int.Parse(Console.ReadLine());
            if (x >= 0 && x<= 25)
            {
                Console.WriteLine("[0;25]");
            }
            else if (x > 25 && x <= 50)
            {
                Console.WriteLine("(25;50]");
            }
            else if (x > 50 && x <= 75 )
            {
                Console.WriteLine("(50;75]");
            }
            else if (x > 75 && x <= 100)
            {
                Console.WriteLine("(75;100]");
            }
        }
    }
}
