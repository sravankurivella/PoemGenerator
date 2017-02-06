using System;
using System.Collections.Generic;

namespace PoemGenerator
{
    class Rule
    {
        private String name;
        private String value;
        private List<List<String>> nonTerminals;

        public Rule()
        {

        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getValue()
        {
            return value;
        }

        public void setValue(String value)
        {
            this.value = value;
        }

        public List<List<String>> getNonTerminals()
        {
            return nonTerminals;
        }

        public void setNonTerminals(List<List<String>> nonTerminals)
        {
            this.nonTerminals = nonTerminals;
        }
    }
}