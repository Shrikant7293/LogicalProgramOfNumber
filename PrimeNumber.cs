using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramOfNumber
{
	internal class PrimeNumber
	{

		public void Primenumber()
		{
			Console.WriteLine("Enter Any Number");
			int Num = Convert.ToInt32(Console.ReadLine());

			int Counter = 0;
			for(int i=1; i <= Num; i++)
			{
				if (Num % i == 0)
				{
				  Counter++;
				}
			}
			if(Counter == 2)
			{
				Console.WriteLine(Num + " is Prime Number");
			}
			else
			{
				Console.WriteLine(Num + " is not Prime Number");

			}
		}
	}
}
