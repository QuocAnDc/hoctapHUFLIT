namespace BT5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INVOICE ");
            Console.WriteLine("______________________________________________________________________________________");
            Console.WriteLine($"{"No",-3} | {"PRODUCT NAME",-20} | {"PRICE",12} | {"QUANTITY",12} | {"TOTAL(RS)",12:F2}");

            Console.Write("the number of products: ");
            int soluong = int.Parse(Console.ReadLine());

            double sum = 0;
            for (int i = 1; i <= soluong; i++)
            {
                Console.Write($"- Code of Product {i}: ");
                double code = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                double quantity = double.Parse(Console.ReadLine());

                switch (code)
                {

                    case 1:

                        Console.WriteLine($"{i,-3} | {"Cochorro Quente",-20} | {"4.00",12} | {quantity,12} | {quantity * 4.00,12:F2}");
                        break;
                    case 2:

                        Console.WriteLine($"{i,-3} | {"X - Salada",-20} | {"4.50",12} | {quantity,12} | {quantity * 4.50,12:F2}");
                        break;
                    case 3:

                        Console.WriteLine($"{i,-3} | {"X-Bacon",-20} | {"5.00",12} | {quantity,12} | {quantity * 5.00,12:F2}");
                        break;
                    case 4:

                        Console.WriteLine($"{i,-3} | {"Torrada simples",-20} | {"2.00",12} | {quantity,12} | {quantity * 2.00,12:F2}");
                        break;
                    case 5:

                        Console.WriteLine($"{i,-3} | {"Refrigerante",-20} | {"1.00",12} | {quantity,12} | {quantity * 1.00,12:F2}");
                        break;
                    default:
                        Console.WriteLine("nhap code sai");
                        break;
                }
                Console.WriteLine($"TOTAL: {sum:f2}");

                Console.WriteLine("Enter your choice (1 - continue / 0 - exit): ");
                int choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Clear();
                }
                else if (choice == 0)
                {
                    Console.Write("Thank you & Goodbye! ");
                    break ;
                }
            }
           
        }
    }
}
