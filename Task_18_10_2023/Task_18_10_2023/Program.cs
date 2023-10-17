// ps2 part1 task10
/*static long Fact(long n)
{
    if (n == 0) return 1;
    else return n * Fact(n - 1);
}

int k = 1, count = 1;
double e = 0.01;
double x = double.Parse(Console.ReadLine());

double y = Math.Sqrt(1 + x), y0 = 1;
while (Math.Abs(y - y0) > e)
{
    double numerator = Math.Pow(-1, k) * Fact(2 * k);
    double denominator = (1 - 2 * k) * Math.Pow(Fact(k), 2) * Math.Pow(4, k);
    y0 += (numerator / denominator) * Math.Pow(x, k);
    k++;
    count++;
}

Console.WriteLine($"y: {y} y0: {y0} count = {count-1}");

*/


//ps2 part2 task4
/*
int k = 1;
double p = Math.PI, p0 = 0, e = 0.1;

static double Sum(double s, int k)
{
    s += 1 / ((4 * k - 2) * (4 * k - 1));
    return s;
}

while (Math.Abs(p-p0) > e)
{
    p0 = (8 * Sum(p0, k)) + (2 * Math.Log(2));
    k++;
}
Console.WriteLine($"p: {p} p0: {p0}");
*/


//ps2 part4 task 3

static double func(double x)
{
    return -(Math.Tan(1/x + x));
}
// формула левых прямоугольников
static double lRect(double a, double b, int n)
{
    double sum = 0.0;
    double h = (b - a) / n;
    for (int i = 0; i < n; i++)
    {
        sum += h * func(a + i * h);
    }
    return sum;
}
// формула правых прямоугольников
static double rRect(double a, double b, int n)
{
    double sum = 0.0;
    double h = (b - a) / n;
    for (int i = 0; i < n; i++)
    {
        sum += h * func(a + (i + 1) * h);
    }
    return sum;
}
// формула трапеций
static double Trapeze(double a, double b, double n)
{
    double x, h, s;
    h = (b - a) / n;
    s = (func(a) + func(b)) / 2;
    for (x = a + h; x < b; x += h)
    {
        s += func(x);
    }
    return s * h;
}
// формула Симпсона
static double Simpson(double a, double b, int n)
{
    double h = (b - a) / n;
    double sum1 = 0, sum2 = 0;
    for (int i = 1; i <= n; i++)
    {
        var xi = a + i * h;
        if (i <= n - 1)
        {
            sum1 += func(xi);
        }

        var xi_1 = a + (i - 1) * h;
        sum2 += func((xi + xi_1) / 2);
    }

    var result = h / 3 * (1 / 2 * func(a) + sum1 + 2 * sum2 + 1 / 2 * func(b));
    return result;
}
// формула Монте-Карло
static double MonteCarlo(double a, double b, int n)
{
    double XLen = 1 / n;
    double YLen = 1.6 / n;
    double innerCount = 0, count = 0;
    for (double x = a; x <= b; x += XLen)
    {
        double f = func(x);
        for (double y = 0; y <= 1.6; y += YLen)
        {
            if (y >= 0 && y <= f) innerCount++;
            count++;
        }
    }
    return innerCount / count * 1.6; 
}

int n = 1000;
double a = 0.5, b = 2.5, result = 2.56805;

Console.WriteLine($"По формуле левых прямоугольников получилось = {lRect(a,b,n)}  |  " +
    $"Разница: {lRect(a, b, n) - result}\n");

Console.WriteLine($"По формуле правых прямоугольников получилось = {rRect(a, b, n)}  |  " +
    $"Разница: {rRect(a, b, n) - result}\n");

Console.WriteLine($"По формуле трапеций получилось = {Trapeze(a, b, n)}  |  " +
    $"Разница: {Trapeze(a, b, n) - result} \n");

Console.WriteLine($"По формуле Симпсона получилось = {Simpson(a, b, n)}  |  " +
    $"Разница: {Simpson(a, b, n) - result}\n");









































