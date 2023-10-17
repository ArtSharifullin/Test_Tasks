// ps2 part1 task10

Console.WriteLine("-------------------------------------------------\n Ps2 p1 task10\n");
Console.WriteLine(SqrtOnePlusX(0.01));
static string SqrtOnePlusX(double eps)
{
    int count = 1, k = 1;
    Console.Write("Введите число x (|x|<=1) для формулы Sqrt(1 + x): ");
    double x = double.Parse(Console.ReadLine());
    double kfact = 1, k2fact = 2;
    double y = Math.Sqrt(1 + x), y0 = 1;
    while (Math.Abs(y - y0) > eps)
    {
        y0 += ((Math.Pow(-1, k) * k2fact) / ((1 - (2*k)) * Math.Pow(kfact,2) * Math.Pow(4,k))) * Math.Pow(x,k);
        k++;
        kfact *= k;
        k2fact *= (k+1) * (k+2);
        count++;
    }
    Console.WriteLine($"y: {y} y0: {y0}");
    return $"count = {count}";
}
    


//ps2 part2 task4
Console.WriteLine("-------------------------------------------------\n Ps2 p2 task4\n");

Console.WriteLine($"Наше число П: {Pi(0.001)}");
Console.WriteLine($"Число П: {Math.PI}");
static double Pi(double eps)
{
    double pi = Math.PI;
    double res = 0;
    double k = 1;
    double log = Math.Log(2);
    while (Math.Abs(pi - (8 * res + 2 * log)) > eps)
    {
        res += 1 / (4 * k - 2) / (4 * k - 1);
        k++;
    }
    return 8 * res + 2 * log;
}




//ps2 part4 task 3
Console.WriteLine("-------------------------------------------------\n Ps2 p4 task3\n");
static double func(double x)
{
    return -(Math.Tan(1/x + x));
}
// формула левых прямоугольников
static double lRect(double a, double b, double n)
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
static double rRect(double a, double b, double n)
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
static double Simpson(double a, double b, double n)
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
static double MonteCarlo(double a, double b, double n)
{
    Random r = new Random();
    double sum = 0;
    for (var i = 1; i <= n; i++)
    {
        sum += func(r.Next((int)(a * 10), (int)(b * 10)) / 10.0);
    }
    return sum * (b - a) / n;
}

int n = 1000;
double a = 0.5, b = 2.5, result = 2.56805;


Console.WriteLine($"По формуле левых прямоугольников получилось = {lRect(a, b, n)}  |  " +
    $"Разница: {lRect(a, b, n) - result}\n");

Console.WriteLine($"По формуле правых прямоугольников получилось = {rRect(a, b, n)}  |  " +
    $"Разница: {rRect(a, b, n) - result}\n");

Console.WriteLine($"По формуле трапеций получилось = {Trapeze(a, b, n)}  |  " +
    $"Разница: {Trapeze(a, b, n) - result} \n");

Console.WriteLine($"По формуле Симпсона получилось = {Simpson(a, b, n)}  |  " +
    $"Разница: {Simpson(a, b, n) - result}\n");

Console.WriteLine($"По формуле Монте-Карло получилось = {MonteCarlo(a, b, n)}  |  " +
    $"Разница: {MonteCarlo(a, b, n) - result}\n");









































