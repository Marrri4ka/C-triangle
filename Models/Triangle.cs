using System;

namespace MySpace {

  class Triangle
  {
    private int Side1;
    private int Side2;
    private int Side3;

    public Triangle (int side1, int side2, int side3)
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }

    public string Result()
    {
      if(Side1 == Side2 && Side2 == Side3)
      {
        return  "equilateral";
      }
      else if (Side1+Side2<=Side3 || Side1+Side3<=Side2 || Side1+Side3<=Side2)
      {
        return "invalid";
      }
      else if (Side1 == Side2 || Side2 == Side3 || Side1 == Side3)
      {
        return  "isosceles";
      }
      else
      {
        return "scalene";
      }
    }

}
}
