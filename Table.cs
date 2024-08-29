using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramOfNumber
{
	internal class Table
	{
		public void PrintTable()
		{
			Console.WriteLine("Enter Any Number");
			int Num = Convert.ToInt32(Console.ReadLine());
			
			int Count=0;

			for(int i = 1; i <=10; i++)
			{
				 Count = Num * i;
				Console.WriteLine(Count);
			}
		}
	}
}
