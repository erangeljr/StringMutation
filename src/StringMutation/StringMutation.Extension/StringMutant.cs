namespace StringMutation.Extension
{
    public static class StringMutant
    {
        public static string StringExtension(this string input)
        {
            return input;
        }

        public static string[] Lines(this string input  )
        {
            
            return input.Split('\n');
        }

    }
}
