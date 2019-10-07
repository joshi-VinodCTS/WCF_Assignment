namespace CalculatorServiceLib
{
    public class CalculatorService : ICalculatorService
    {
        public int AddTwoNumbers(int n1, int n2)
        {
            return n1 + n2;
        }

        public int DivideTwoNumbers(int n1, int n2)
        {
            return n1 / n2;
        }

        public int MultiplyTwoNumbers(int n1, int n2)
        {
            return n1 * n2;
        }

        public int SubtractTwoNumbers(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}