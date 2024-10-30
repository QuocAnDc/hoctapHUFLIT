using System.Diagnostics;

namespace BT9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("nhap code: ");
            double code = double.Parse(Console.ReadLine());
            Console.Write("nhap so luong: ");
            double quantity = double.Parse(Console.ReadLine());

            Console.WriteLine($"{"PRODUCT NAME",-20} | {"PRICE",12} | {"QUANTITY",12} | {"TOTAL(RS)",12:F2}");

            switch (code) {

                case 1:

                    Console.WriteLine($"{"Cochorro Quente",-20} | {"4.00",12} | {quantity,12} | {quantity * 4.00,12:F2}");
                    break;
                case 2:

                    Console.WriteLine($"{"X - Salada",-20} | {"4.50",12} | {quantity,12} | {quantity * 4.50,12:F2}");
                    break;
                case 3:

                    Console.WriteLine($"{"X-Bacon",-20} | {"5.00",12} | {quantity,12} | {quantity * 5.00,12:F2}");
                    break;
                case 4:

                    Console.WriteLine($"{"Torrada simples",-20} | {"2.00",12} | {quantity,12} | {quantity * 2.00,12:F2}");
                    break;
                case 5:

                    Console.WriteLine($"{"Refrigerante",-20} | {"1.00",12} | {quantity,12} | {quantity * 1.00,12:F2}");
                    break;
            }
        }   
    }
}
