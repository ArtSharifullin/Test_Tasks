using System;
using System.Text;
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

        public double RealPart
        {
            get { return Math.Round(module * Math.Cos(argument), 3); }
        }

        public double ImaginaryPart
        {
            get { return Math.Round(module * Math.Sin(argument), 3); }
        }

        public double Module
        {
            get { return module; }
        }

        public double Argument
        {
            get { return argument; }
        }

        public static ComplexNum operator *(ComplexNum a, ComplexNum b)
        {
            var r = (a.RealPart * b.RealPart) - (a.ImaginaryPart * b.ImaginaryPart);
            var i = (a.RealPart * b.ImaginaryPart) + (a.ImaginaryPart * b.RealPart);
            return ComplexNum.Alg(r, i);
        }

        public static ComplexNum operator /(ComplexNum a, ComplexNum b)
        {
            var denom = (b.RealPart * b.RealPart) + (b.ImaginaryPart * b.ImaginaryPart);

            if (denom != 0)
            {
                var r = ((a.RealPart * b.RealPart) + (a.ImaginaryPart * b.ImaginaryPart))/denom;
                var i = ((b.RealPart * a.ImaginaryPart) - (a.RealPart * b.ImaginaryPart))/denom;

                return ComplexNum.Alg(r, i);
            }
            else { return ComplexNum.Alg(0, 0);}
        }

        public override string ToString()
        {
            if (RealPart != 0 && ImaginaryPart > 0) { return $"{RealPart} + {ImaginaryPart}i"; }
            if (RealPart != 0 && ImaginaryPart < 0) { return $"{RealPart} - {Math.Abs(ImaginaryPart)}i"; }
            return $"{ImaginaryPart}i";
        }
    }
}

