using System;
using System.Linq;

namespace ExtensionMethods
{
    public static class StringExtensions
    {
        public static string Shorten(this String str, int NumberOfWords)
        {
            if (NumberOfWords < 0)
                throw new ArgumentOutOfRangeException("number should be greater then 0");

            if (NumberOfWords == 0)
            {
                return "";
            }

            var words = str.Split(' ');

            if (words.Length <= NumberOfWords)
            {
                return str;
            }

            return string.Join(" ", words.Take(NumberOfWords)) + "...";
            
        }
    }
}
