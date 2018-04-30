using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets go !");
            var r = LetsGo(10, 5);
            for (int i = 0; i < 8; i++)
            {
                System.Console.WriteLine("");
            }

            TopicVersion();
        }

        static int LetsGo(int a, int b)
        {
            return a * b;
        }

        static void TopicVersion()
        {
            System.Console.WriteLine("whoowhoo");
        }
    }
}
