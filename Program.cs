namespace Miniräknare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write your secound number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write which calculation method you want to chose?");
            Console.WriteLine("Addition + " + " Subtracion - " + " Multiplication * " + " Division / ");
            string metod = Console.ReadLine();
            double result = 0;

            switch (metod)
            {
                case "+":
                    result = number1 + number2;
                    Console.WriteLine("Result: " + result);
                    break;

                case "-":
                    result = number1 - number2;
                    Console.WriteLine("Result: " + result);
                    break;

                case "*":
                    result = number1 * number2;
                    Console.WriteLine("Result: " + result);
                    break;

                case "/":
                    result = number1 / number2;
                    Console.WriteLine("Result: " + result);
                    break;

                default:
                    Console.WriteLine("Unknown metod.");
                    break;
            }
                                
                







        }

    }
}