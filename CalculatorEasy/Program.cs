namespace CalculatorEasy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Användare input
            Console.WriteLine("Första numret tack: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Andra numret tack: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Operator (+, -, *, /, %, or ^):");
            // Varför får jag grön jordgubbland?
            // Hur slipper jag det?
            string operation = Console.ReadLine();

            // Här lägger vi in resultatet senare
            int result;

            // Beräkna veroende på operator
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                case "%":
                    result = number1 % number2;
                    break;
                case "^":
                    result = (int)Math.Pow(number1, number2);
                    break;
                // Utifall en felaktig operator väljs
                default: 
                    Console.WriteLine("Jag känner inte igen denna operator: " + operation);
                    result = 0;
                    break;
            }

            Console.WriteLine(number1 + " " + operation + " " + number2 +
                        " = " + result);

            Console.ReadKey();
        }
    }
}