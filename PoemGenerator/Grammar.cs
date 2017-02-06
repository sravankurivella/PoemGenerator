using System;
using System.Collections.Generic;

namespace PoemGenerator
{
    class Grammar
    {
        private String mainRule;
        private Dictionary<String, Rule> rules;
        public Grammar()
        {

        }
        public Dictionary<String, Rule> getRules()
        {
            if(this.rules == null)
            {
                rules = new Dictionary<String, Rule>();

            }
            return rules;
        }
        public void setRules(Dictionary<String, Rule> rules)
        {
            this.rules = rules;
        }
        public String getMainRule()
        {
            return mainRule;
        }
        public void setMainRule(String mainRule)
        {
            this.mainRule = mainRule;
        }

    }
}