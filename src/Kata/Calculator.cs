using System;
using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string s = "")
        {
            if(string.IsNullOrEmpty(s)) return 0;

            var separator = new [] {",", "\n"};

            if (s.StartsWith("//"))
            {
                var parts = s.Split("\n");
                var listOfNumbers = parts.Last();
                var delimiterDefinition = parts.First();
                var slashesWithSemicolon = delimiterDefinition;
                var semicolon = slashesWithSemicolon.Replace("//","");
                
                separator = new[] { semicolon };
                s = listOfNumbers;
            }

            var numbers = s.Split(separator, StringSplitOptions.None).Select(int.Parse);
            
            return numbers.Sum();

        }
    }
}