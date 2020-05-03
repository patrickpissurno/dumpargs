using System;
using System.Collections;

namespace DumpArgs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dumped env vars:");

            var vars = Environment.GetEnvironmentVariables();
            if (vars.Count > 0)
            {
                Console.WriteLine();
                foreach (DictionaryEntry x in vars)
                    Console.WriteLine(x.Key + " = " + x.Value);
                Console.WriteLine();
            }

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
