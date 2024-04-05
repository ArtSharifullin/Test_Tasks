//Task 4

var d = new Dictionary<string, int>()
{
    { "Kolya" , 50},
    { "Petya", 22},
    { "Alex",35},
    { "Stas", 78 }
};
Console.WriteLine("\n----------Task4------------\n");
Console.WriteLine(d.MaxBy(a => a.Value ));

//Task5

T Last<T>(List<T> list, Func<T, bool> func)
{
    T result = default(T);
    for (int i = list.Count - 1; i >= 0; i--)
    {
        if (func(list[i]))
        {
            result = list[i];
            break;
        }
    }
    return result;
}

var l = new List<int>();
var r = new Random();
for (int i = 0; i <10; i++)
{
    l.Add(r.Next(20));
}
var answer = Last(l, a => a % 2 == 1);
Console.WriteLine("\n----------Task5-----------\n");
Console.WriteLine($"Последний нечетный элемент = {answer}");