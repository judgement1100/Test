using System;

namespace CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("And now I'm going to make a change");
            string someText = "Hey";
            Console.WriteLine(someText);
            HeheImGoing(ref someText);
            Console.WriteLine(someText);
        }

        static void HeheImGoing(ref string text)
        {
            text = "new text";
        }
    }
}
