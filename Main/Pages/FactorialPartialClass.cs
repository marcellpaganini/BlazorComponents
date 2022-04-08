namespace Main.Pages
{
    public partial class FactorialPartialClass
    {
        private int factorialInput = 0;

        private int result = 0;

        private int CalculateFactorial(int currentNumber) 
        {
            if (currentNumber == 1) 
            {
                return 1;
            }

            result = currentNumber * CalculateFactorial(currentNumber - 1); 

            return result; 
        }
    }
}