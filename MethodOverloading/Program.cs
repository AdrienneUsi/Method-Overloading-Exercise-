namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Int Add: {Add(4, 4)}");
            Console.WriteLine($"Decimal Add: {Add(3.0m, 3.0m)}");
            var addedWithBool = Add(2, 2);
            Console.WriteLine(addedWithBool);
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2; ;
        }

        public static decimal Add(decimal num1, decimal num2)
        { return num1 + num2; }

        public static string Add (int num1, int num2, bool isChecked)
        {
            var sum = num1 + num2;
            if (isChecked && sum > 1)
            {
                return $"${sum} dollars";
            }
            else if (isChecked&& sum == 1)
            {
                return $"{sum} dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
        
    }
}
