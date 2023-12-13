using System;
using System.Text;
// 1

namespace ComplexNumClass
{
    public class ComplexNum
    {
        private double realPart;
        private double imaginaryPart;
        public ComplexNum(double r = 0, double i = 0) 
        {
            realPart = r;
            imaginaryPart = i;
        }
        
        public static ComplexNum Alg(double real, double imaginary)
        {
            return new ComplexNum(real, imaginary);
        }

        public static ComplexNum Trig(double module, double argument)
        {
            return new ComplexNum(Math.Round(module * Math.Cos(argument), 5), Math.Round(module * Math.Sin(argument), 5));
        }
        public double RealPart
        {
            get { return realPart; }
        }

        public double ImaginaryPart
        {
            get { return imaginaryPart; }
        }

        public double Module
        {
            get
            {
                double r = realPart;
                double i = imaginaryPart;
                var z = Math.Sqrt(r * r + i * i);

                return z;
            }
        }

        public double Argument
        {
            get
            {
                double r = realPart;
                double i = imaginaryPart;
                double arg = 0;

                if (r > 0) { arg = Math.Atan(i / r); }
                if (r < 0 && i >= 0) { arg = Math.PI + Math.Atan(i / r); }
                if (r < 0 && i < 0) { arg = Math.Atan(i / r) - Math.PI; }
                if (r == 0 && i > 0) { arg = Math.PI / 2; }
                if (r == 0 && i < 0) { arg = -(Math.PI / 2); }

                return arg;
            }
        }

        public static ComplexNum operator +(ComplexNum a, ComplexNum b)
        {
            var r = a.realPart + b.realPart;
            var i = a.imaginaryPart + b.imaginaryPart;
            return new ComplexNum(r, i);
        }

        public static ComplexNum operator -(ComplexNum a, ComplexNum b)
        {
            var r = a.realPart - b.realPart;
            var i = a.imaginaryPart - b.imaginaryPart;
            return new ComplexNum(r, i);
        }

        public override string ToString()
        {
            if (realPart != 0 && imaginaryPart > 0) { return $"{realPart} + {imaginaryPart}i"; } 
            if (realPart != 0 && imaginaryPart < 0) { return $"{realPart} - {Math.Abs(imaginaryPart)}i"; }
            return $"{imaginaryPart}i";
        }
    }
}

