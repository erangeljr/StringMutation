﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32.SafeHandles;

namespace StringMutation.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public static class StringMutant
    {
        /// <summary>
        /// Returns sting input
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string StringExtension(this string input)
        {
            if(String.IsNullOrEmpty(input))
                throw new ArgumentNullException();
            return input;
        }

        /// <summary>
        /// Returns A String Array with each line in an index
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[] Lines(this string input  )
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentNullException();
            return input.Split('\n');
        }

        /// <summary>
        /// Returns a string with the first character Capitalized
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Capitalize(this string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentNullException();
            return input[0].ToString().ToUpper() + input.Substring(1);
        }

        /// <summary>
        /// Returns a String that has every word Capitalized
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Titleize(this string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentNullException();

            var result = input.Split(' ');

            for (int i = 0; i <= result.Length - 1; i++)
            {
                result[i] = Capitalize(result[i]);
            }

            return String.Join(" ", result);
        }

        /// <summary>
        /// Returns a String Array with each word in an index
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string[] Words(this string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentNullException();
            return input.Split(' ');
        }

        /// <summary>
        /// Returns a Char Array with each Char in an index
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static char[] Characters(this string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentNullException();
            return input.ToCharArray();
        }

        /// <summary>
        /// Should return a Chopped String as a String Array
        /// Currently Not Fully Implemented
        /// </summary>
        /// <param name="input"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string Chop(this string input, int value)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentNullException();

            
            return input.Substring(0, value);;
        }

        /// <summary>
        /// Return the number of lines in a string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int CountLines(this string input)
        {
            return input.Split('\n').Length;
        }

        /// <summary>
        /// Returns a string in reverse order
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Reverse(this string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

        }

        /// <summary>
        /// Returns number of characters in a strings
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int CountCharacters(this string input)
        {
            return input.Length;

        }

        /// <summary>
        /// Returns a string with left leading spaces removed
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string LeftTrim(this string input)
        {
            return input.TrimStart();
        }

        /// <summary>
        /// Returns a string with right trailing spaces removed
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string RightTrim(this string input)
        {
            return input.TrimEnd();
        }

        /// <summary>
        /// Returns an array of Chars 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Chars(this string input)
        {
            return input;
        }
    }
}
