namespace Console_parsed_input
{
    public static class ConsoleReader
    {
        /// <summary>
        /// ask the user until it gets a number in the console
        /// </summary>
        /// <returns>given number</returns>
        public static int ReadInt()
        {
            string? inp;
            int val = -1;

            do inp = Console.ReadLine();
            while (string.IsNullOrEmpty(inp) || !Int32.TryParse(inp, out val));

            return val;
        }

        /// <summary>
        /// ask the user until it gets a number suitable for the conditions in the console
        /// </summary>
        /// <param name="condition">condition for needed number</param>
        /// <returns>returns number</returns>
        public static int ReadInt(Predicate<int> condition)
        {
            string? inp;
            int val = -1;

            while (true)
            {
                inp = Console.ReadLine();

                if (!string.IsNullOrEmpty(inp) && Int32.TryParse(inp, out val))
                {
                    if (!condition.Invoke(val))
                        continue;

                    return val;
                }
            }
        }


        /// <summary>
        /// ask user until it gets a string in the console
        /// </summary>
        /// <returns>returns given string</returns>
        public static string ReadString()
        {
            string? inp;

            do inp = Console.ReadLine();
            while (string.IsNullOrEmpty(inp));

            return inp;
        }
    }
}