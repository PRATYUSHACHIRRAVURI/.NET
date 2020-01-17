using System;

			
public class Program
{
  public static void Main()
  {
   
            int first_number;
            int second_number;
            string operate;
            float result;
 
           
                Console.Write("Please enter the first integer: ");
                first_number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter the second integer: ");
                second_number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter an operator (+, -, /, *): ");
                operate = Console.ReadLine();
 
                switch (operate)
                {
                    case "-":
                        result = substract(first_number,second_number);
                        break;
                    case "+":
                        result = add(first_number,second_number);
                        break;
                    case "/":
                        result = divide(first_number,second_number);
                        break;
                    case "*":
                        result = multiply(first_number,second_number);
                        break;
                    default:
                        result = 0;
                        break;
                }
 
                Console.WriteLine(first_number.ToString() + " " + operate + " " + second_number.ToString() + " = " + result.ToString());
              
            
    }
  static int add(int operator1,int operator2){

        return operator1+operator2;

    }

        static int substract(int operator1,int operator2){

        return operator1-operator2;

    }

        static int multiply(int operator1,int operator2){

        return operator1*operator2;

    }

        static int divide(int operator1,int operator2){

            return operator1/operator2;

    }
}
 
 