using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Soz.Area
{
    public class Triangle
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public Triangle(int x, int y, int z)
        {
            if ((x + y) <= z)
            {
                throw new ArgumentException($"Такой треугольник не существует. {x} + {y} <= {z}");
            }

            if ((x + z) <= y)
            {
                throw new ArgumentException($"Такой треугольник не существует. {x} + {z} <= {y}");
            }

            if ((z + y) <= x)
            {
                throw new ArgumentException( $"Такой треугольник не существует. {x} + {y} <= {z}");
            }
        }

        public double GetArea()
        {
            double HalfPer = (X + Y + Z)/2; //HalfPerimeter 
            double S = Math.Sqrt(HalfPer * (HalfPer - X) * (HalfPer - Y) * (HalfPer - Z));
            return S;
        }

        public bool IsRectangular()
        {
            if ((X*X + Y*Y) == (Z * Z))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}