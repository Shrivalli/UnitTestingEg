using System;

namespace UnitTestingEg
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            int res=c.add(5, 4);
            Console.WriteLine(res);
            Console.WriteLine("Hello World!");
        }
    }
}
