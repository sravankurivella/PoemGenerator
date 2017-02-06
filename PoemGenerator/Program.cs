using System;

namespace PoemGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadRules gp = new ReadRules();
            Console.WriteLine(args.Length);
            if (args.Length != 1)
            {
                Console.WriteLine("Please enter the file with path as an argument to the function. Exiting ");
                Console.ReadKey();
                return;
            }
            String fileName = args[0];
            Grammar grammar = gp.parseGrammar(fileName);
            //RandomPoemGenerator rgp = new RandomPoemGenerator();
            GeneratePoem.generatePoem(grammar);
           
            Console.ReadKey();
        }
    }
}
