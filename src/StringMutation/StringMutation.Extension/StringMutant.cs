using System;

namespace StringMutation.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public static class StringMutant
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string StringExtension(this string input)
        {
            return input;
        }

        /// <summary>
        /// Returns A String Array with each line in an index
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[] Lines(this string input  )
        {
            return input.Split('\n');
        }

        /// <summary>
        /// Returns a string with the first character Capitalized
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Capitalize(this string input)
        {
            return input[0].ToString().ToUpper() + input.Substring(1);
        }

        public static string Titleize(this string input)
        {
            var result = input.Split(' ');

            for (int i = 0; i <= result.Length - 1; i++)
            {
                result[i] = Capitalize(result[i]);
            }

            return String.Join(" ", result);
        }

    }
}
