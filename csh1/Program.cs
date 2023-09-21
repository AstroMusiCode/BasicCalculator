using System;

namespace Programs 
{
	public class Program 
	{
		private static double n1, n2;
		private static double n3 = 0;
		private static string repeat = "y";
		public static void Main(string[] args)
		{
			while (repeat.Equals("y")) 
			{
				Console.WriteLine("First Number: ");
				double n1 = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Operation: ");
				string operation = Console.ReadLine();
				Console.WriteLine("Second Number: ");
				double n2 = Convert.ToDouble(Console.ReadLine());
				switch (operation) 
				{
					case "+":
						n3 = n1 + n2;
						break;
					case "-":
						n3 = n1 - n2;
						break;
					case "*":
						n3 = n1 * n2;
						break;
					case "/":
						n3 = n1 / n2;
						break;
					default:
						break;
				}
				Console.WriteLine("Result: " + n3 + "\n");
				Console.WriteLine("Again? (y/n) ");
				repeat = Console.ReadLine();
				Console.WriteLine();
				
			}
			
		}
	}
}