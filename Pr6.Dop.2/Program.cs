using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            long result; //присвоение лок.переменной "result" целочисленного типа "long".
            const long km = 149800000; // Присвоение целочисленного типа "long" лок.переменной "km" и присвоение значения константы.
            result = km * 1000 * 100; // Вычисление лок.переменной "result"
            Console.WriteLine(result);// вывод на экран результата вычисления "result".
        }
    }
}