using System;

namespace MySpace{

public class Program
{
  public static void Main()
  {
    Console.WriteLine("Enter first side: ");
    string firstSide = Console.ReadLine();
    int side1 = int.Parse(firstSide);

    Console.WriteLine("Enter second side: ");
    string secondSide = Console.ReadLine();
    int side2 = int.Parse(secondSide);

    Console.WriteLine("Enter third side: ");
    string thirdSide = Console.ReadLine();
    int side3 = int.Parse(thirdSide);

    Triangle myTriangle = new Triangle (side1,  side2, side3);
    string res = myTriangle.Result();
    Console.WriteLine("Your triangle is" + " " + res);
    }
  }
}
