using ComplexNumClass2;

ComplexNum2 a = new ComplexNum2(3, -4);
ComplexNum2 b = new ComplexNum2(5);

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

Console.Write("a * b = ");
ComplexNum2.Multiplication(a, b);
Console.WriteLine("------------------------------------------------");

Console.Write("a / b = ");
ComplexNum2.Division(a, b);
Console.WriteLine("------------------------------------------------");


















