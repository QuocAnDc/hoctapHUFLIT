﻿namespace BT6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n} x {1,2} = {n*1,2}");
            Console.WriteLine($"{n} x {2,2} = {n*2,2}");
            Console.WriteLine($"{n} x {3,2} = {n*3,2}");
            Console.WriteLine($"{n} x {4,2} = {n*4,2}");
            Console.WriteLine($"{n} x {5,2} = {n*5,2}");
            Console.WriteLine($"{n} x {6,2} = {n*6,2}");
            Console.WriteLine($"{n} x {7,2} = {n*7,2}");
            Console.WriteLine($"{n} x {8,2} = {n*8,2}");
            Console.WriteLine($"{n} x {9,2} = {n*9,2}");
            Console.WriteLine($"{n} x {10,2} = {n*10,2}");
        }
    }
}
