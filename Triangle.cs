using System;
using System.Collections.Generic;
using System.Text;

namespace CalcAreaLib
{
    public class Triangle : Figure
    {
        private double SideA;
        private double SideB;
        private double SideC;
        private bool Rectangularity;

        public Triangle(double triangle_sideA, double triangle_sideB, double triangle_sideC)
        {
            SideA = triangle_sideA;
            SideB = triangle_sideB;
            SideC = triangle_sideC;
            if (Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2)
                || Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2) 
                || Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2))
            {
                Rectangularity = true;
            }
        }


        public override string Area()
        {
            double halfPerimetr = (SideA + SideB + SideC) / 2;
            return Convert.ToString(Math.Sqrt(halfPerimetr * (halfPerimetr - SideA) * (halfPerimetr - SideB) * (halfPerimetr - SideC))); 
        }



        
         public override string FigureName()
        {
            if (Rectangularity == true) { return "Rectangular Triangle"; }
            else {return "Triangle"; }
            
        }
        



    }
}
