using System;
namespace Sorting
{
    public class Programm
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
			
			Programm.Binary(array, 0, 0);
			
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
        public static void Binary(int[] array, int left, int right)
        {
            left = 0; 
            right = array.Length - 1; 
            int index = 0; 
 
            int q = Convert.ToInt32(Console.ReadLine());
            int res = -1;
 
            while (left <= right)
            {
                index = (right + left) / 2; 
 
                
                if (array[index] == q)
                {
                    res = index;
                    break;
                }
                
                if (array[index] < q)
                {
                    left = index + 1;
                }
                else
                {
                    right = index - 1;
                }
            }
 
            if (res != -1)
            {
                Console.WriteLine("Присутсвует индекс: " + res);
            }
            else
            {
                Console.WriteLine("Отсутсвует");
            }
        }
    }
}