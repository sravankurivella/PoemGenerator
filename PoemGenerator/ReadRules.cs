using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PoemGenerator
{
    class ReadRules
    {
        public Grammar parseGrammar(String fileName)
        {
            String line;
            StreamReader file = new StreamReader(fileName);
            Grammar grammar = new Grammar();
            while ((line = file.ReadLine()) != null)
            {
                Rule rule = new Rule();
                String[] rv = line.Split(':');
                String ruleName = rv[0].Trim();
                String value = rv[1].Trim();
                rule.setName(ruleName);
                rule.setValue(value);
                setRootRuleName(grammar, ruleName);
                String[] evaluables = value.Split(' ');
                List<List<String>> evals = new List<List<String>>();
                foreach (String evaluable in evaluables)
                {

                    // List of possible options to each element that requires
                    // evaluation
                    String[] options = evaluable.Trim().Split('|');
                    List<String> opts = new List<String>();

                    foreach (String option in options)
                    {
                        opts.Add(option);
                    }
                    evals.Add(opts);
                }
                rule.setNonTerminals(evals);
                grammar.getRules().Add(ruleName, rule);
            }
            file.Close();
            return grammar;

        }

        private void setRootRuleName(Grammar grammar, string ruleName)
        {
            if(grammar.getMainRule() == null)
            {
                grammar.setMainRule(ruleName);
            }
        }        
    }
}
