using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets go !");
            var r = LetsGo(10, 5);
            for (int i = 0; 4 < 8; i++)
            {
                System.Console.WriteLine("");
            }
        }

        static int LetsGo(int a, int b)
        {
            return a * b;
        }
    }
}
