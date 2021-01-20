using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program opens a message saying "Hello World"
            Console.WriteLine("Hello World!");
            Console.WriteLine("Click any key to start the program closing procedure");
            //User is able to close program by clicking any key on their keyboard
            Console.ReadKey(true);
        }
    }
}
