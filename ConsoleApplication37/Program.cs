﻿/*
 *  4 / 2 is 2
 *  dev by zero
 *  Outcome of 15 / 4is not even
 *  32 / 4 is 8
 *  dev by zero
 *  Outcome of 127 / 8is not even
 *  No matching element found
 *  No matching element found
 */

using System;

class Program
{
	static void Main()
	{
		int[] numb	= { 4, 8, 15, 32, 64, 127, 256, 512 };
		int[] denom	= { 2, 0, 4, 4, 0, 8 };
		for (int i = 0; i < numb.Length; i++)
		{
			try
			{
				if ((numb[i] % 2) != 0)				
					throw new NonIntResult("Outcome of " + numb[i] + " / " + denom[i] + "is not even");
				else Console.WriteLine(numb[i] + " / " + denom[i] + " is " + numb[i] / denom[i]);
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("dev by zero");
			}
			catch (IndexOutOfRangeException)
			{
				Console.WriteLine("No matching element found");
			}
			catch(NonIntResult exc)
			{
				Console.WriteLine(exc);
			}
		}
		//Console.ReadLine();
	}
}