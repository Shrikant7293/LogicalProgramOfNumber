using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramOfNumber
{
	internal class OddEven
	{
		public void OddEvenNumber()
		{
			Console.WriteLine("Entern Any Number");
			int Limit = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Odd Number");

			for(int i=1; i<=Limit; i++) // Odd Number
			{
				if(i % 2 == 1)
				{
					Console.Write(i + " ");
				}
			}

			Console.WriteLine("Even Number");

			for (int i=1; i<=Limit;i++)  // Even Number
			{
				if (i % 2 == 0)
				{
					Console.Write(i + " ");
				}
			}
		}
	}
}
