using System;

namespace Second_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum,div,sub,mul;
            string option,str1,str;
             //const string a;
             //const string b;
                 str1 = @"
                          a - Addition
                          s - Subtraction
                          m - Multiplication
                          d - Division
                          
                          Your option?"; 
         for(int i = 1; i >= 1; i++)
         {   
         Console.WriteLine("Type a number, and then press Enter:");
         var FirstNum = Convert.ToDecimal(Console.ReadLine());
         
         Console.WriteLine("Type another number, and then press Enter:");
         var SecondNum = Convert.ToDecimal(Console.ReadLine());

         Console.WriteLine("Choose an operator from the following list");

         Console.WriteLine(str1);
         option = Console.ReadLine();
         

            switch (option)
            {   
                case "a":
                    sum = Math.Round(FirstNum + SecondNum, 4);
                    Console.WriteLine("The sum is {0}" , sum);
                    break;

                case "m":
                    mul = Math.Round(FirstNum * SecondNum, 4); 
                    Console.WriteLine("The product is " + mul);
                    break;

                case "s":
                    sub = Math.Round(FirstNum - SecondNum, 4);
                    Console.WriteLine("The difference is " + sub);
                    break;

                case "d":
                   /* if (SecondNum == 0) 
                         throw new DivideByZeroException("Cannot divide by a negative number");*/
                    try {
                    div = Math.Round(FirstNum / SecondNum, 4);
                    Console.WriteLine("The dividend is {0}" , div);
                    }

                    catch (Exception ex) {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    break;

         
            
                default:
                    Console.WriteLine("This operation will result in a mathematical error.");
                    break;


           }
            Console.WriteLine("press 'n' and enter to close the app,or press any other key and enter to continue");
           str = Console.ReadLine();
           if(str == "n")
            break;

          
         }
         
         
        }
    }
}
 