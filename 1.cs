using System;
namespace Sorting
{
    class Programm
    {


        public static void Main(string[] args)
        {

            int[] array = new int[10];
            array[0] = 25;
            array[1] = 15;
            array[2] = 154;
            array[3] = 145;
            array[4] = 19;
            array[5] = 88;
            array[6] = 5;
            array[7] = 45;
            array[8] = 14;
            array[9] = 10;

            var result = Inciment(array);

        }


        public static int[] Inciment(int[] array)
        {
            int t;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
                Console.WriteLine(array[i] + ", ");
            }
            return array;
        }






    }
}