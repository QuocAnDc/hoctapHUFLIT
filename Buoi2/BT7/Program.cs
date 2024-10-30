namespace BT7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap so a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("nhap so b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Nhap phep toan (+, -, *, /, %): ");
            string pheptinh= Console.ReadLine();

            switch (pheptinh)
            {
                case "+":
                    Console.WriteLine($"{a} + {b} = {a+b}");
                    break;
                case "-":
                    Console.WriteLine($"{a} - {b} = {a - b}");
                    break;
                case "*":
                    Console.WriteLine($"{a} * {b} = {a * b}");
                    break;
                case "/":
                    Console.WriteLine($"{a} / {b} = {a / b}");
                    break;
                case "%":
                    Console.WriteLine($"{a} % {b} = {a % b}");
                    break;
            }
        }
    }
}
