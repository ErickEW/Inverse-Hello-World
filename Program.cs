using System;

namespace Inverse_Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello World!";
            int charCount = "Hello World!".Length;
            char[] caracterHelloWorld = new char[charCount];
            Console.WriteLine("Hello World!");

            //caracterHelloWorld[0]

            // Console.WriteLine(helloWorld);

            // Console.WriteLine(helloWorld.Substring(0,5));

            // Console.WriteLine(helloWorld[0]);

            for (int i = 0; i < charCount; i++) {
                Console.WriteLine(helloWorld[i]);

                int newIndex = (helloWorld.Length - 1) - i;
                caracterHelloWorld[i] = helloWorld[i];
            }

            Console.WriteLine(caracterHelloWorld);

        }
    }
}
