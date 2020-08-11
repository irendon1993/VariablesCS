using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfCupsOfCoffee = 0;
            var fullName = "Isaac Rendon";
            DateTime today = new DateTime(2020, 08, 11);

            Console.WriteLine($"Hello my name is {fullName},and I drank {numberOfCupsOfCoffee} cups of coffee today, {today}");

            Console.WriteLine("What is your name? ");
            Console.WriteLine("\n");


            var userName = Console.ReadLine();

            if (userName == "Alice")
            {
                Console.WriteLine("Woah I've been waiting for you Alice!");
            }

            else
            {
                Console.WriteLine($"Nice to meet you, { userName}");
            }


            Console.WriteLine("Please enter two numbers");
            var firstNumberAsString = Console.ReadLine();
            var secondNumberAsString = Console.ReadLine();

            Console.WriteLine("\n");
            Console.WriteLine($"The numbers you input are {firstNumberAsString} and {secondNumberAsString}");

            Console.WriteLine("\n");

            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);

            var sum = firstOperand + secondOperand;
            var difference = secondOperand - firstOperand;
            var product = secondOperand * firstOperand;
            var quotient = firstOperand / secondOperand;
            var remainder = firstOperand % secondOperand;

            Console.WriteLine("\n");

            Console.WriteLine($"The sum of {firstOperand} and {secondOperand} is equal to {sum}");
            Console.WriteLine($"The difference of {firstOperand} and {secondOperand} is equal to {difference}");
            Console.WriteLine($"The product of {firstOperand} and {secondOperand} is equal to {product}");
            Console.WriteLine($"The quotient of {firstOperand} by {secondOperand} is equal to {quotient}");
            Console.WriteLine($"The remainder of {firstOperand} from {secondOperand} is equal to {remainder}");



        }
    }
}
