namespace Calculator
{
    public static class SuperCalculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(int a, int b)
        {
            //Fail test to trigger failure in CI pipeline.
            return a / b;
        }
    }
}
