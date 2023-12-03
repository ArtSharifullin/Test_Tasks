using System;
// 2

namespace ComplexNumClass
{
    public class ComplexNum
    {
        private double module;
        private double argument;

        public ComplexNum(double m = 0, double a = 0)
        {
            module = m;
            argument = a;
        }

        public static ComplexNum Alg(double r, double i)
        {
            var mod = Math.Sqrt(r * r + i * i);
            var arg = 0.0;

            if (r > 0) { arg = Math.Atan(i / r); }
            if (r < 0 && i >= 0) { arg = Math.PI + Math.Atan(i / r); }
            if (r < 0 && i < 0) { arg = Math.Atan(i / r) - Math.PI; }
            if (r == 0 && i > 0) { arg = Math.PI / 2; }
            if (r == 0 && i < 0) { arg = -(Math.PI / 2); }

            return new ComplexNum(Math.Round(mod,5), Math.Round(arg,5));
        }

        public static ComplexNum Trig(double mod, double arg)
        {
            return new ComplexNum(mod, arg);
        }

        public double RealPart()
        {
            return Math.Round(module * Math.Cos(argument),3);
        }

        public double ImaginaryPart()
        {
            return Math.Round(module * Math.Sin(argument),3);
        }

        public double Module
        {
            get { return module; }
        }

        public double Argument
        {
            get { return argument; }
        }

        public static void Multiplication(ComplexNum a, ComplexNum b)
        {
            var r = (a.RealPart() * b.RealPart()) - (a.ImaginaryPart() * b.ImaginaryPart());
            var i = (a.RealPart() * b.ImaginaryPart()) + (a.ImaginaryPart() * b.RealPart());
            if (i > 0) { Console.WriteLine($"{Math.Round(r)} + {Math.Round(i)}i"); }
            else if (i < 0) { Console.WriteLine($"{Math.Round(r)} - {Math.Abs(Math.Round(i))}i"); }
            else Console.WriteLine(r);
        }

        public static void Division(ComplexNum a, ComplexNum b)
        {
            var denom = (b.RealPart() * b.RealPart()) + (b.ImaginaryPart() * b.ImaginaryPart());

            if (denom != 0)
            {
                var r = ((a.RealPart() * b.RealPart()) + (a.ImaginaryPart() * b.ImaginaryPart()))/denom;
                var i = ((b.RealPart() * a.ImaginaryPart()) - (a.RealPart() * b.ImaginaryPart()))/denom;

                if (i > 0) { Console.WriteLine($"{Math.Round(r,5)} + {Math.Round(i,5)}i"); }
                else if (i < 0) { Console.WriteLine($"{Math.Round(r, 5)} - {Math.Abs(Math.Round(i, 5))}i"); }
                else Console.WriteLine(r);
            }
            else { Console.WriteLine("Знаменатель равен нулю, деление невозможно !"); }
   
        }  
    }
}

