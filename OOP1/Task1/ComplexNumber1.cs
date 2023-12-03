using System;
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

        public double Module()
        {
            double r = realPart;
            double i = imaginaryPart;
            var z = Math.Sqrt(r * r + i * i);

            return z;
        }

        public double Argument()
        {
            double r = realPart;
            double i = imaginaryPart;
            double arg = 0;

            if (r > 0) { arg = Math.Atan(i / r); }
            if (r < 0 &&  i >= 0) { arg = Math.PI + Math.Atan(i / r); }
            if (r < 0 && i < 0) { arg = Math.Atan(i / r) - Math.PI; }
            if (r == 0 && i > 0) { arg = Math.PI/2; }
            if (r == 0 && i < 0) { arg = -(Math.PI / 2); }

            return arg;
        }

        public static void Sum(ComplexNum a, ComplexNum b)
        {

            var r = a.realPart + b.realPart;
            var i = a.imaginaryPart + b.imaginaryPart;
            if (i > 0) { Console.WriteLine($"{r} + {i}i"); }
            else if (i < 0) { Console.WriteLine($"{r} - {Math.Abs(i)}i"); }
            else Console.WriteLine(r);
        }

        public static void Subtraction(ComplexNum a, ComplexNum b)
        {
            var r = a.realPart - b.realPart;
            var i = a.imaginaryPart - b.imaginaryPart;
            if (i > 0) { Console.WriteLine($"{r} + {i}i"); }
            else if (i < 0) { Console.WriteLine($"{r} - {Math.Abs(i)}i"); }
            else Console.WriteLine(r);
        }
    }
}

