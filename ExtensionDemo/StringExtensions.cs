using System;
using System.Globalization;

namespace ExtensionDemo
{
    public static class StringExtensions
    {
        /// <summary>
        /// Converts ALL CAPS string to Title Case
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ToTitleCase(this string input)
        {
            if (input.IsAllUpper())
            {
                TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
                return textInfo.ToTitleCase(input.ToLower());
            }
            return input;
        }

        private static bool IsAllUpper(this string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]) && !Char.IsUpper(input[i]))
                    return false;
            }
            return true;
        }
    }
}
