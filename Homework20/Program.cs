using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework20
{
    internal class Program
    {
        delegate double MyDelegate(double radius);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = GetLen;
            double length = myDelegate(1);
            Console.WriteLine(length);
            
            myDelegate = GetSquare;
            double square = myDelegate(1);
            Console.WriteLine(square);
            
            myDelegate = GetVol;
            double volume = myDelegate(1);
            Console.WriteLine(volume);
            Console.ReadKey();
        }

        static double GetLen(double radius) => 2 * Math.PI * radius;
        static double GetSquare(double radius) => Math.PI * radius * radius;
        static double GetVol(double radius) => 4.0 / 3 * Math.PI * Math.Pow(radius, 3);

    }
}
