using System;
using System.Collections.Generic;
using System.Text;

namespace CalcAreaLib
{
    public class Circle : Figure
    {
        private double Radius;

        public Circle(double circle_radius)
        {
            Radius = circle_radius;
        }

        public override string Area()
        {
            return Convert.ToString(Math.PI*Math.Pow(Radius,2)); 
        }




        public override string FigureName()
        {
            return "Circle";   
        }

    }
}
