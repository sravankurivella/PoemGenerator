using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PoemGenerator
{
    class GeneratePoem
    {
        static StreamWriter w = new StreamWriter("log.txt");
        public static void generatePoem(Grammar grammar) 
        {
            Rule rootRule = grammar.getRules()[(grammar.getMainRule())];
            
            TerNonTer(rootRule, grammar);
            w.Close();
        }

        public static void TerNonTer(Rule rule, Grammar grammar)
        {
            
            Dictionary<String, Rule> a = grammar.getRules();
            List<List<String>> evaluables = rule.getNonTerminals();
            foreach (List<String> options in evaluables)
            {

                int random = new Random().Next(0,options.Count);
                w.Write(random.ToString() + " ");
                //Console.WriteLine("Random - " + random);
                String opt = options.ElementAt(random);
                if (opt.Trim().StartsWith("<")){
                    Rule subRule = grammar.getRules()[(opt.Substring(1, opt.Length - 2))];
                    TerNonTer(subRule, grammar);
                }
                else if (opt.StartsWith("$"))
                {
                    Console.Write("\n");
                }
                else
                {
                    Console.Write(opt + " ");
                }
            }
        }
    }
}
