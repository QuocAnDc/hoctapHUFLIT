namespace BT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap x = ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("nhap y = ");
            int y = int.Parse(Console.ReadLine());

            int sum = 0;
            //for (int i = x+1; i < y; i++)
            //{
            //    if (i % 2 != 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine($"tong = {sum}");
            for (int i = y + 1; i < x; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"tong = {sum}");
        }
    }
}
