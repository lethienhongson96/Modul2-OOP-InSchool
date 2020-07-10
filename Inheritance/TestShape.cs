using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class TestShape
    {
        public static void Main()
        {
            Random rnd = new Random();
            int percent = rnd.Next(1,100);
            Square square = new Square();
            square.Resize(percent);
            Console.WriteLine(square.GetSide());
        }
    }
}
