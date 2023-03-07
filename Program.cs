using System;

namespace Second_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum,div,sub,mul;
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
         var FirstNum = Convert.ToInt32(Console.ReadLine());
         
         Console.WriteLine("Type another number, and then press Enter:");
         var SecondNum = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Choose an operator from the following list");

         Console.WriteLine(str1);
         option = Console.ReadLine();
         

            switch (option)
            {   
                case "a":
                    sum = FirstNum + SecondNum;
                    Console.WriteLine("The sum is {0}" , sum);
                    break;

                case "m":
                    mul = FirstNum * SecondNum;
                    Console.WriteLine("The product is " + mul);
                    break;

                case "s":
                    sub = FirstNum - SecondNum;
                    Console.WriteLine("The difference is " + sub);
                    break;

                case "d":
                    div = FirstNum / SecondNum;
                    Console.WriteLine("The dividend is {0}" , div);
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
 