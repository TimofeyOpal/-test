using System;
namespace App
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string s = Console.ReadLine();

            Console.WriteLine(CheckRPS(s) ? "ѕравильна€ последовательность" : "Ќе правильна€ последовательность");
        }

        public static bool CheckRPS(string quotes)
        {

            int counter = 0;

            for (int i = 1; i < quotes.Length; i++)
            {
                //Console.WriteLine(quotes[i]);
                if (quotes[i] == '(')
                {
                    counter++;
                }
                else if (quotes[i] == ')')
                {
                    counter--;
                }

                if (counter < 0) return true;
            }


            return counter == 1;
        }
    }
}
//не работает 