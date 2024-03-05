using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NumberInDegreeClass;
//ps3 Task15

/*var r = new Random();
int a = r.Next(40000);
int b = r.Next(40000);
int m = r.Next(10);
int n = r.Next(10);
var x = new NubmerInDegree(a, m);
var y  = new NubmerInDegree(b, n);
Console.WriteLine($"{a} {m}");
Console.WriteLine(x);
Console.WriteLine(x.Value);*/

Console.WriteLine(Math.Pow(38246, 9));
var x = 1;
for (int i = 0; i < 9; i++)
{
    x *= 38246;
}
Console.WriteLine(x);   