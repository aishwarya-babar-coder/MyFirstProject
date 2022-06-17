using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Exam
{
    class Pred2
    {
		static void Main(string[] args)
		{
			// k= number of spaces
			int k = 2 * 5 - 2, i, j;

			// outer loop to handle number of rows

			for (i = 0; i < 5; i++)
			{

				// inner loop to handle number spaces
				// values changing acc. to requirement
				for (j = 0; j < k; j++)
				{
					// printing spaces
					Console.Write(" ");
				}

				// decrementing k after each loop
				k = k - 1;

				// inner loop to handle number of columns

				for (j = 0; j <= i; j++)
				{
					// printing stars
					Console.Write("* ");
				}

				// ending line after each row
				Console.WriteLine();
			}
		}
    }
}
