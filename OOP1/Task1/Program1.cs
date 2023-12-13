using ComplexNumClass;

ComplexNum a = ComplexNum.Alg(1, 2);
ComplexNum b = ComplexNum.Trig(5,Math.PI);

Console.WriteLine("------------------------------------------------");
Console.WriteLine("1 Task :\n");

Console.WriteLine($"realPart(a) = {a.RealPart}");
Console.WriteLine($"realPart(b) = {b.RealPart}");
Console.WriteLine("------------------------------------------------");

Console.WriteLine($"imaginaryPart(a) = {a.ImaginaryPart}");
Console.WriteLine($"imaginaryPart(b) = {b.ImaginaryPart}");
Console.WriteLine("------------------------------------------------");

Console.WriteLine($"module(a) = {a.Module}");
Console.WriteLine($"module(b) = {b.Module}");
Console.WriteLine("------------------------------------------------");

Console.WriteLine($"arg(a) = {a.Argument}");
Console.WriteLine($"arg(b) = {b.Argument}");
Console.WriteLine("------------------------------------------------");

Console.WriteLine($"a + b = {a + b}");
Console.WriteLine("------------------------------------------------");

Console.WriteLine($"a - b = {a - b}");
Console.WriteLine("------------------------------------------------");