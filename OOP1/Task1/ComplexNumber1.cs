using System;
// 1

namespace ComplexNumClass1
{
    public class ComplexNum1
    {
        private readonly double realPart;
        private readonly double imaginaryPart;

        public ComplexNum1(double r, double i)
        {
            realPart = r;
            imaginaryPart = i;
        }

        public ComplexNum1(double i) : this(0,i)
        {
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
            var z = Math.Sqrt(realPart * realPart + imaginaryPart * imaginaryPart);
            return z;
        }

        public double Argument()
        {
            double arg = 0;
            if (realPart > 0) { arg = Math.Atan(imaginaryPart / realPart); }
            if (realPart < 0 &&  imaginaryPart >= 0) { arg = Math.PI + Math.Atan(imaginaryPart / realPart); }
            if (realPart < 0 && imaginaryPart < 0) { arg = Math.Atan(imaginaryPart / realPart) - Math.PI; }
            if (realPart == 0 && imaginaryPart > 0) { arg = Math.PI/2; }
            if (realPart == 0 && imaginaryPart < 0) { arg = -(Math.PI / 2); }

            return arg;
        }

        public void AlgShow()
        {
            if (imaginaryPart > 0) { Console.WriteLine($"{realPart} + {imaginaryPart}i"); }
            else { Console.WriteLine($"{realPart} - {Math.Abs(imaginaryPart)}i"); }
        }

        public void TrigShow()
        {
            Console.WriteLine($"{Module()} * (cos({Argument()}) + isin({Argument()}))");
        }

        public static void Sum(ComplexNum1 a, ComplexNum1 b)
        {
            var r = a.realPart + b.realPart;
            var i = a.imaginaryPart + b.imaginaryPart;
            if (i > 0) { Console.WriteLine($"{r} + {i}i"); }
            else if (i < 0) { Console.WriteLine($"{r} - {Math.Abs(i)}i"); }
            else Console.WriteLine(r);
        }

        public static void Subtraction(ComplexNum1 a, ComplexNum1 b)
        {
            var r = a.realPart - b.realPart;
            var i = a.imaginaryPart - b.imaginaryPart;
            if (i > 0) { Console.WriteLine($"{r} + {i}i"); }
            else if (i < 0) { Console.WriteLine($"{r} - {Math.Abs(i)}i"); }
            else Console.WriteLine(r);
        }
    }
}

