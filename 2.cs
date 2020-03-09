using System;
using System.Linq;

public class Test
{
	public static void Main()
	{
		var array = new int[] { 8, 4, 2, 44, 3, 10 };
		int name;
		name = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(array.Contains(name) ? "Есть" : "Отсутствует");
	}
}