using System;


namespace lab2
{    class Program
    {
        static int Main(string[] args)
        {
            RomanNumber testr = new RomanNumber(10);
            Console.WriteLine($"Num1 = {testr.ToString()}");
            RomanNumber testr2 = new RomanNumber(6);
            Console.WriteLine($"Num2 = {testr2.ToString()}");
            RomanNumber testr3 = RomanNumber.Add(testr, testr2);
            Console.WriteLine($"\nAdd = {testr3.ToString()}");
            RomanNumber testr4 = RomanNumber.Sub(testr, testr2);
            Console.WriteLine($"Sub = {testr4.ToString()}");
            RomanNumber testr5 = RomanNumber.Mul(testr, testr2);
            Console.WriteLine($"Mul = {testr5.ToString()}");
            RomanNumber testr6 = RomanNumber.Div(testr, testr2);
            Console.WriteLine($"Div = {testr6.ToString()}");

            Console.WriteLine($"\nOriginal is {testr3.ToString()}");
            var clon = (RomanNumber)testr3.Clone();
            Console.WriteLine($"Copy is {clon.ToString()}\n");


            RomanNumber sort1 = new RomanNumber(12);
            RomanNumber sort2 = new RomanNumber(5);
            RomanNumber sort3 = new RomanNumber(10);
            RomanNumber[] mas = { sort1, sort2, sort3 };
            Console.WriteLine($"\nOriginal massive");
            for (int i = 0; i < 3; i++) Console.WriteLine($"{mas[i].ToString()}");
            Array.Sort(mas);
            Console.WriteLine($"\nSorted massive");
            for (int i = 0; i < 3; i++) Console.WriteLine($"{mas[i].ToString()}");
            return 0;

        }
    }
}
