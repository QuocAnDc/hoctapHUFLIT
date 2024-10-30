namespace BT10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Attendant mark: ");
            Double a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Practical mark: ");
            Double b = Double.Parse(Console.ReadLine());
            Console.WriteLine("Final exam: ");
            Double c = Double.Parse(Console.ReadLine());
            Double diemtb;
            diemtb = a*0.2+b*0.3+c*0.5;
            Console.WriteLine($"Average mark: {diemtb}");
        }
    }
}
