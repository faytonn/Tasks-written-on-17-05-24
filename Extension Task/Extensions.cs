namespace Extension_Task
{
    public static class Extensions
    {
        public static bool isOdd(this int number)
         => number % 2 == 0;
        
        public static bool isEven(this int number)
         => number % 2 != 0;

        public static bool ContainsDigit(this string word)
        {
            foreach (char c in word)
            {
                if (char.IsDigit(c))
                {

                    return true;
                }

            }
                return false;
        }
            

        

    }
}
