using System;

namespace Vector_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector test1 = new Vector(6, 21, 0 );
            Vector test2 = new Vector(30, 21, 0);
            
            // This should be 0, 4, 0
            Console.WriteLine(Vector.Add(test1, test2));
            Console.WriteLine(test1.GetDirection());
        }
    }
}
