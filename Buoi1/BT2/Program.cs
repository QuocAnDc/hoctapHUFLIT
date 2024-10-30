namespace BT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input string: ");
            string stringNumber;
            stringNumber = Console.ReadLine();
            Console.WriteLine($"stringNumber value & type: {stringNumber},{stringNumber.GetType()}");
            int intNumber;
            intNumber = int.Parse( stringNumber );
            Console.WriteLine($"stringNumber value & type: {intNumber},{intNumber.GetType()}");
        }
    }
}
