namespace task_1_lab_27_06
{
    public static class Extensions
    {
        public static int Factorial(this int number)
        {
            int result = 1;

            if (number == 0)
            {
                return 1;
            }

            #region loop method
            //for (int i = 1; i <= number; i++)
            //{
            //   result *= i;

            //}
            //return result;
            #endregion

            #region recursive function method
            return number * Factorial(number - 1);
            #endregion
        }
            
        

        
        

        
    }
}
