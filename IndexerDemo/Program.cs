using System;

namespace IndexerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray fruits = new MyArray(1, 4);
            fruits[1] = "Apple";
            fruits[2] = "Orange";
            fruits[3] = "Banana";
            fruits[4] = "Pineapple";

            Console.WriteLine(fruits[1]);
            Console.WriteLine(fruits[4]);
        }
    }
}
