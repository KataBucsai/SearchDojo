using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SearchDojo
{
    public class PatternSearcher
    {
        public static List<string> Search(string text, string pattern)
        {
            var matches = Regex.Matches(text, pattern);
            List<string> results = new List<string>();
            foreach (Match match in matches)
            {
                results.Add(match.Value);
            }
            return results;
        }
    }
}
