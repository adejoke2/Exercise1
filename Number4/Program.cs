using System;

namespace Number4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter your number:");
            double number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Put in your operator: ");
            string Operator = Console.ReadLine();

            Console.Write("Enter the second number:");
            double number2 = Convert.ToInt32(Console.ReadLine());

           switch(Operator){
               case "+":
               case "Add":
               Console.WriteLine(number1 + number2);
               break;

               case "*":
               case "Multiply":
               Console.WriteLine(number1 * number2);
               break;

               case "-":
               case "Subtract":
               Console.WriteLine(number1 - number2);
               break;

               case "/":
               case "Divide":
               Console.WriteLine(number1 / number2);
               break;

               case "%":
               case "Modulos":
               Console.WriteLine(number1 % number2);
               break;

               default:
               Console.WriteLine("This is not a correct input");
               break;
           }
        }
    }
}
