using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _24.Regular_Expression
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
                 * CHARACTER ESCAPES:
                 * ------------------
                 \t - Matches a tab
                 \n - Matches a new line

                 * CHARACTER CLASSES:
                 * ------------------
                 .  - Wildcard: Matches any single character except \n.
                 \d - Matches any decimal digit. (0 - 9)
                 \D - Matches any character other than a decimal digit. (0 - 9)
                 \w - Word Character(a - z, A - Z, 0 - 9, _)
                 \W - Not a Word Character
                 \s - Matches any white-space character. (space, tab, newline)
                 \S - Matches any non-white - space character(space, tab, newline)
                 [character_group] - Matches any single character in character_group.By default, the match is case-sensitive.
                 [^character_group] - Negation: Matches any single character that is not in character_group.By default, characters in 
                 character_group are case-sensitive.

                 * ANCHORS:
                 * --------
                 ^ -The match must start at the beginning of the string or line.
                 $       -The match must occur at the end of the string or before \n at the end of the line or string.
                 \A - The match must occur at the start of the string.
                 \Z - The match must occur at the end of the string or before \n at the end of the string.
                 \b - Word Boundary
                 \B - Not a Word Boundary

                 * ALTERNATION CONSTRUCTS:
                 * -----------------------
                 | -Either Or

                 * GROUPING CONSTRUCT:
                 * -------------------
                 () - Group

                 * QUANTIFIERS:
                 * ------------
                 *-Matches the previous element zero or more times.
                 + -Matches the previous element one or more times.
                 ? -Matches the previous element zero or one time.
                 { n} -Matches the previous element exactly n times.
                 { n,m} -Matches the previous element at least n times, but no more than m times.
            */

            string pattern = @"\d";
            Regex regex = new Regex(pattern);
            string text = "Hi there, my number is 12345";
            MatchCollection matchCollection = regex.Matches(text);
            Console.WriteLine("{0} hits found:\n{1}", matchCollection.Count, text);
            foreach (Match hit in matchCollection)
            {
                GroupCollection group = hit.Groups;
                Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
            }

            Console.ReadKey();
        }
    }
}
