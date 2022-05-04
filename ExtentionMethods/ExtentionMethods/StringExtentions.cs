using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionMethods
{
    // extention method (static) inside namespace ExtentionMethods
    public static class StringExtentions
    {
        //use this String str to call the function on a string without creating an instance of the class StringExtentions (so like existingString.Shorten(5))
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 1)
                throw new ArgumentOutOfRangeException("Number of words should be higher than 0.");

            var words = str.Split(' ');
            if (words.Length == numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords)) + "...";
        }
    }
}
