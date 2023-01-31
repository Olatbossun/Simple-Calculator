using System;

class Program
{
    public static void Main(string[] args)
    {
      //Description of the operations
        Console.WriteLine("Press \"+\" for addition, \"-\" for subtraction, \"\\\" for division, \"*\" for multiplication");

      //input first number value
        Console.Write("Enter first_number: ");
        double firstNum = Convert.ToDouble(Console.ReadLine());
      //select operand
        Console.Write("Enter operand: ");
        string operand = Console.ReadLine();
      //input second number
        Console.Write("Enter second_number: ");
      //convert number input to cover for both real and decimal values
        double secondNum = Convert.ToDouble(Console.ReadLine());
      
        double result = 0;
      //conditional statement to check for operation to be carried out
        switch (operand)
        {
            case "+":
                {
                    result = Addition(firstNum, secondNum);
                    break;
                }
            case "-":
                {
                    result = Subtraction(firstNum, secondNum);
                    break;
                }
            case "*":
                {
                    result = Multiplication(firstNum, secondNum);
                    break;
                }
        case "/":
                {
                    result = Division(firstNum, secondNum);
                    break;
                }
          //default value if wrong operand or input is entered
            default:
                Console.WriteLine("Error!, Enter a valid operator");
                break;
        }
  //output format
        Console.WriteLine("Result: {0} {1} {2} = {3}", firstNum, operand, secondNum, result);
        Console.ReadKey();
    }
    //functions to carry out on each of the input 
    //Addition operation  
    public static double Addition(double firstNum, double secondNum)
    {
        double result = firstNum + secondNum;
        return result;
    }
    //Substraction operation  
    public static double Subtraction(double firstNum, double secondNum)
    {
        double result = firstNum - secondNum;
        return result;
    }
    //Multiplication operation 
    public static double Multiplication(double firstNum, double secondNum)
    {
        double result = (firstNum * secondNum);
        return result;
    }
    //Division  operation
    public static double Division(double firstNum, double secondNum)
    {
        double result = (firstNum / secondNum);
        return result;
    }
}
