namespace FizzBuzz
{
    public static class FizzBuzz
    {
        public static string GetValue(int number)
        {
            string result = "";

            if (number % 3 == 0)
                result += "Fizz";

            if (number.ToString().Contains('3'))
                result += "Fizz";

            if (number % 5 == 0)
                result += "Buzz";

            if (number.ToString().Contains('5'))
                result += "Buzz";

            return result == "" ? number.ToString() : result;
        }
    }
}
