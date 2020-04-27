using System;
using System.Security.Cryptography.X509Certificates;

namespace Soz.Area
{
    public class Circle
    {
        private int X { get; }

        public Circle(int x)
        {
            X = x;
        }
        
        public double GetArea(int AfterDot)
        {
            double S = Math.PI * X;
            S = Math.Round(S, AfterDot); 
            return S;
        }
    }
}
