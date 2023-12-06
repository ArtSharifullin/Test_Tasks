// 2 вариант 

// 1 task

int[] arr = { 1, 2, 3, 4, 5, 4, 3, 2, 1 };
int count = 0;
for (int i = 0; i < arr.Length / 2; i++)
{
    if (arr[i] == arr[arr.Length - i - 1])
    {
        count++;
    }
}
if (count == arr.Length / 2)
{
    Console.WriteLine("Массив симметричен");
}
else Console.WriteLine("Массив не симметричен");


// 2 task

int[] arr2 = new int[10];
Console.WriteLine($"\n Введите 10 чисел для массива второго задания :");
for (int i = 0; i < arr2.Length; i++)
{
    arr2[i] = int.Parse(Console.ReadLine());
}

int count2 = 0, res = 0;

for (int i = 1; i < arr2.Length; i++)
{
    if ((arr2[i - 1] <= arr2[i]) && (count2 == 0)) { count2++; }
    if (arr2[i - 1] > arr2[i])
    {
        count2 = 0;
        res++;
    }
}

// Проверяю яыляется ли последняя цепочка массива возрастающей
if (count2 != 0)
{
    res++;
}
Console.WriteLine($"\nresult = {res}");



// Task 3
Random r = new Random();
int[] minij = new int[2];
int[] maxij = new int[2];
int size = 10, minimal = 100, maximal = 0;
int[,] matr = new int[size, size];

Console.WriteLine("\n\nБыло\n");
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        matr[i, j] = r.Next(100); // заполняю массив рандомными значениями

        if (matr[i,j] < minimal) // ищу индексы минимального числа
        {  
            minimal = matr[i,j];
            minij[0] = i;
            minij[1] = j;
        }

        else if (matr[i,j] > maximal)  // ищу индексы максимального числа
        {   
            maximal = matr[i,j];
            maxij[0] = i;
            maxij[1] = j;
        }
        Console.Write($"{matr[i, j],3} ");
    }
    Console.WriteLine();
}

//Меняю Максимальное и Минимальное занчение местами
int a = matr[minij[0], minij[1]];
matr[minij[0], minij[1]] = matr[maxij[0], maxij[1]];
matr[maxij[0], maxij[1]] = a;

// вывожу массив
Console.WriteLine($"\n\nСтало    Поменял местами [{minij[0]},{minij[1]}] на [{maxij[0]},{maxij[1]}] и обратно\n");
for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        Console.Write($"{matr[i, j],3} ");
    }
    Console.WriteLine();
}




































































































































































