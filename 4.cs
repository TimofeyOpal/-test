using System;

namespace Factorial
{
    class MainClass
    {
       
        public static int fact(int n)
            
        {
            int output;
            output = 1;
            for (int i = 1; i <= n; i++) 
                output *= i;
            return output;
        }
        public static void Main (string[] args)
        {
            Console.WriteLine("Факториал числа равен " + fact(15));
        }

    }
            
}



