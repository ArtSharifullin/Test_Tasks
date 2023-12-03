using System;
// 2

namespace ComplexNumClass2
{
    public class ComplexNum2
    {
        private readonly double realPart;
        private readonly double imaginaryPart;

        public ComplexNum2(double r, double i)
        {
            realPart = r;
            imaginaryPart = i;
        }

        public ComplexNum2(double i) : this(0, i)
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
            if (realPart < 0 && imaginaryPart >= 0) { arg = Math.PI + Math.Atan(imaginaryPart / realPart); }
            if (realPart < 0 && imaginaryPart < 0) { arg = Math.Atan(imaginaryPart / realPart) - Math.PI; }
            if (realPart == 0 && imaginaryPart > 0) { arg = Math.PI / 2; }
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

        public static void Multiplication(ComplexNum2 a, ComplexNum2 b)
        {
            var r = (a.realPart * b.realPart) - (a.imaginaryPart * b.imaginaryPart);
            var i = (a.realPart * b.imaginaryPart) + (a.imaginaryPart * b.realPart);
            if (i > 0) { Console.WriteLine($"{r} + {i}i"); }
            else if (i < 0) { Console.WriteLine($"{r} - {Math.Abs(i)}i"); }
            else Console.WriteLine(r);
        }

        public static void Division(ComplexNum2 a, ComplexNum2 b)
        {
            var denom = (b.realPart * b.realPart) + (b.imaginaryPart*b.imaginaryPart);

            if (denom != 0)
            {
                var r = ((a.realPart * b.realPart) + (a.imaginaryPart * b.imaginaryPart))/denom;
                var i = ((b.realPart * a.imaginaryPart) - (a.realPart * b.imaginaryPart))/denom;

                if (i > 0) { Console.WriteLine($"{r} + {i}i"); }
                else if (i < 0) { Console.WriteLine($"{r} - {Math.Abs(i)}i"); }
                else Console.WriteLine(r);
            }
            else { Console.WriteLine("Знаменатель равен нулю, деление невозможно !"); }
   
        }  
    }
}

