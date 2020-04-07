using System;

namespace DumpArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dumped args:");

            if (args.Length > 0)
            {
                Console.WriteLine();
                foreach (string s in args)
                    Console.Write(s);
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
