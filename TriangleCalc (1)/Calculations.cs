/*
 * 
 * Name: Kyle O'Brien
 * Date: 7/13/2016
 * Course Project
 * 
 */
using System;

namespace TriangleCalc
{
	/// <summary>
	/// Description of Calculations.
	/// </summary>
	public class Calculations
	{
		//class properties
		public double SideA {get; set;}
		public double SideB {get; set;}
		public double SideC {get; set;}
		public double TwoSideSum {get; set;}//sum of two sides		
		public double ASqu {get; set;}//Side A squared
		public double BSqu {get; set;}//Side B squared
		public double CSqu {get; set;}//Side C squared		
		public double AngleA {get; set;}
		public double AngleB {get; set;}
		public double AngleC {get; set;}		
		public double Perimeter {get; set;}
		public double SemiP {get; set;}//semi-perimeter		
		public double Area {get; set;}		
		public double HeightA {get; set;}
		public double HeightB {get; set;}
		public double HeightC {get; set;}		
		public double AngleBisectorA {get; set;}
		public double AngleBisectorB {get; set;}
		public double AngleBisectorC {get; set;}		
		public double MedianA {get; set;}
		public double MedianB {get; set;}
		public double MedianC {get; set;}		
		public double InsRadius {get; set;}//inscribed circle radius
		public double CircumRadius {get; set;}//circumscribed circle radius
		
		public void validTest(ref bool validTriangle)
		{
			//sums two sides at a time and compares the sum to third side
			//determines if sides can create a valid triangle
			
			TwoSideSum = SideA + SideB;
			
			if(TwoSideSum > SideC)
			{
				TwoSideSum = SideA + SideC;
				if(TwoSideSum > SideB)
				{
					TwoSideSum = SideB + SideC;
					if(TwoSideSum > SideA)
					{
						validTriangle = true;
					}
				}
			}
		}//end method
		
		
		public void findAngles()
		{
			//calculates the square of the of the side lengths
			ASqu = SideA * SideA;
			BSqu = SideB * SideB;
			CSqu = SideC * SideC;
			
			//calculates each angle, using Law of Cosines
			AngleA = Math.Acos(((BSqu + CSqu) - ASqu) / (2 * (SideB * SideC)));	
			AngleB = Math.Acos(((CSqu + ASqu) - BSqu) / (2 * (SideC * SideA)));
			AngleC = Math.Acos(((ASqu + BSqu) - CSqu) / (2 * (SideA * SideB)));						
		}//end method
		
		public void findArea()
		{
			//calculates area using Heron's Formula
			SemiP = 0.5 * (SideA + SideB + SideC);//semi-perimeter			
			Area = Math.Sqrt(SemiP * (SemiP - SideA) * (SemiP - SideB) * (SemiP - SideC));
		}//endmethod
		
		public void findPerimeter()
		{
			//calculates perimeter
			Perimeter = SideA + SideB + SideC;
		}//end method
		
		public void findHeights()
		{
			//calcultes each sides height
			HeightA = Area / (0.5 * SideA);
			HeightB = Area / (0.5 * SideB);
			HeightC = Area / (0.5 * SideC);
		}//end method
		
		public void findAngleBisector()
		{	
			//calculates angle bisectors
			AngleBisectorA = (2 * SideB * SideC) * (Math.Cos(AngleA/2)) / (SideB + SideC);
			AngleBisectorB = (2 * SideA * SideC) * (Math.Cos(AngleB/2)) / (SideA + SideC);
			AngleBisectorC = (2 * SideA * SideB) * (Math.Cos(AngleC/2)) / (SideA + SideB);
		}//end method
		
		public void findMedians()
		{
			//calculates triangle medians
			MedianA = Math.Sqrt(((2 * BSqu) + (2 * CSqu) - ASqu)) / 2;
			MedianB = Math.Sqrt(((2 * ASqu) + (2 * CSqu) - BSqu)) / 2;
			MedianC = Math.Sqrt(((2 * ASqu) + (2 * BSqu) - CSqu)) / 2;			
		}//end method
		
		public void InsCircleRadius()
		{
			//calculates inscribed circle radius
			InsRadius = SideA * Math.Sin(AngleC/2) * Math.Sin(AngleB/2) / Math.Cos(AngleA/2);
		}//end method
		
		public void CircumCircleRadius()
		{
			//calculates circumscribed cirlce radius
			CircumRadius = SideA / (2 * Math.Sin(AngleA));
		}//end method
		
		public void displayResults(Calculations triangle)
		{
			Console.WriteLine("\n\nAngle A: {0} degrees", Math.Round(AngleA *= 180 / Math.PI, 2));//displays angle in degrees
			Console.WriteLine("Angle B: {0} degrees", Math.Round(AngleB *= 180 / Math.PI, 2));//displays angle in degrees
			Console.WriteLine("Angle C: {0} degrees", Math.Round(AngleC *= 180 / Math.PI, 2));//displays angle in degrees
			Console.WriteLine("Area: {0}", Math.Round(Area, 2));
			Console.WriteLine("Perimeter: {0}", Math.Round(Perimeter, 2));
			Console.WriteLine("Height of A: {0}", Math.Round(HeightA, 2));
			Console.WriteLine("Height of B: {0}", Math.Round(HeightB, 2));
			Console.WriteLine("Height of C: {0}", Math.Round(HeightC, 2));
			Console.WriteLine("Angle Bisector of Side a: {0}", Math.Round(AngleBisectorA, 2));
			Console.WriteLine("Angle Bisector of Side b: {0}", Math.Round(AngleBisectorB, 2));
			Console.WriteLine("Angle Bisector of Side c: {0}", Math.Round(AngleBisectorC, 2));
			Console.WriteLine("Median of Side a: {0}", Math.Round(MedianA, 2));
			Console.WriteLine("Median of Side b: {0}", Math.Round(MedianB, 2));
			Console.WriteLine("Median of Side c: {0}", Math.Round(MedianC, 2));
			Console.WriteLine("Inscribed Circle Radius: {0}", Math.Round(InsRadius, 2));
			Console.WriteLine("Circumscribed Circle Radius: {0}", Math.Round(CircumRadius, 2));
		}//end method
		
	}
}
