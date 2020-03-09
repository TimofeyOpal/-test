using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {


        string str = "dd dd dd d dg ";
        string[] writes = str.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);


        for (int i = 0; i < writes.Length; i++)
        {
            string write = writes[i];

            int count = 0;
            foreach (string elem in writes)
            {
                if (elem == write)
                    count++;
            }
            if (count == 1)
                Console.WriteLine(writes[i]);
        }

        Console.ReadLine();


    }
}
