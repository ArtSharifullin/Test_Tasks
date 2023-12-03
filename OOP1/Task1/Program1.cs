using ComplexNumClass1;

ComplexNum1 a = new ComplexNum1(3, -4);
ComplexNum1 b = new ComplexNum1(5);

Console.WriteLine($"realPart(a) = {a.RealPart}");
Console.WriteLine("------------------------------------------------");

Console.WriteLine($"imaginaryPart(a) = {a.ImaginaryPart}");
Console.WriteLine("------------------------------------------------");

Console.WriteLine($"module(a) = {a.Module()}");
Console.WriteLine("------------------------------------------------");

Console.WriteLine($"arg(a) = {a.Argument()}");
Console.WriteLine("------------------------------------------------");

Console.Write("Alg z(a) = ");
a.AlgShow();
Console.WriteLine("------------------------------------------------");

Console.Write("Trig z(a) = ");
a.TrigShow();
Console.WriteLine("------------------------------------------------");

Console.Write("a + b = ");
ComplexNum1.Sum(a, b);
Console.WriteLine("------------------------------------------------");

Console.Write("a - b = ");
ComplexNum1.Subtraction(a, b);
Console.WriteLine("------------------------------------------------");


















