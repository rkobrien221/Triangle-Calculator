/*
 * 
 * Name: Kyle O'Brien
 * Date: 7/13/2016
 * Course Project
 */
using System;

namespace TriangleCalc
{
	class TriangleCalc
	{
		public static void Main(string[] args)
		{
			Calculations triangle = new Calculations();
			
			bool validTriangle = false;
			
			while(validTriangle == false)
			{
				//This loop asks for users input for triangle sides,
				//loop stops if the three sides input make a valid triangle
			
				Console.Write("Please enter the value for the side a: ");
				triangle.SideA = Convert.ToInt32( Console.ReadLine() );
				Console.Write("Please enter the value for the side b: ");
				triangle.SideB = Convert.ToInt32( Console.ReadLine() );
				Console.Write("Please enter the value for the side c: ");
				triangle.SideC = Convert.ToInt32( Console.ReadLine() );
			
				triangle.validTest(ref validTriangle);
			
				if(validTriangle == false)
					Console.WriteLine("These sides do not make a valid triangle, please enter new sides.\n");			
			}
			
			triangle.findAngles();
			triangle.findArea();
			triangle.findPerimeter();
			triangle.findHeights();
			triangle.findAngleBisector();
			triangle.findMedians();
			triangle.InsCircleRadius();
			triangle.CircumCircleRadius();
			triangle.displayResults(triangle);
								
			Console.ReadKey(true);
		}		
	}
}