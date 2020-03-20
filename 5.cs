using System;
namespace App
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string s = Console.ReadLine();

            Console.WriteLine(CheckRPS(s) || Check(s) || Chec(s) ? "Правильная последовательность" : "Не правильная последовательность");

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
        public static bool Check(string quotes)
        {

            int counter = 0;

            for (int i = 1; i < quotes.Length; i++)
            {
                //Console.WriteLine(quotes[i]);
                if (quotes[i] == '{')
                {
                    counter++;
                }
                else if (quotes[i] == '}')
                {
                    counter--;
                }

                if (counter < 0) return true;
            }


            return counter == 1;
        }
        public static bool Chec(string quotes)
        {

            int counter = 0;

            for (int i = 1; i < quotes.Length; i++)
            {
                //Console.WriteLine(quotes[i]);
                if (quotes[i] == '[')
                {
                    counter++;
                }
                else if (quotes[i] == ']')
                {
                    counter--;
                }

                if (counter < 0) return true;
            }


            return counter == 1;
        }
    }
}