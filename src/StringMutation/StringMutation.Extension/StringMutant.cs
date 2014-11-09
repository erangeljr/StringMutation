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

    }
}
