using System;
using System.Security.Cryptography.X509Certificates;

namespace Soz.Area
{
    public class Circle
    {
        public int X { get; }
        
        public double GetArea()
        {
            double S = 3.14 * X;
            return S;
        }
    }
}
