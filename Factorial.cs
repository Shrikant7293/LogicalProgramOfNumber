using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramOfNumber
{
	internal class Factorial
	{
		public void FactorialNumber()
		{
			
			Console.WriteLine("Enter any Number: ");
			int Number = Convert.ToInt32(Console.ReadLine());

			int fact = 1;
			for (int i = 1; i <= Number; i++)
			{
				fact = fact * i;
			}
			Console.WriteLine("Factorial of " + Number + " is: " + fact);
		}
	}
}
