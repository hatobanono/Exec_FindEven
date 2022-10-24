using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] int1 = new int[] {4, 15};
			int start = int1[0];
			int end = int1[1];

			if (start % 2 == 1)
			{
				start++;
			}
			
			while (start <= end)
			{
				Console.WriteLine(start);
				start += 2;
			}
		}
	}
}
