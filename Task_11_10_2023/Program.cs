// ps1 . part 1 . task 1

/*Console.Write("Введите букву шахматной клетки: ");
char x = char.Parse(Console.ReadLine());
Console.Write("Введите цифру шахматной клетки: ");
int y = int.Parse(Console.ReadLine());

if ((x % 2 == 0) && (y % 2 == 0))
{
    Console.WriteLine("BLACK");
}
else
{
    Console.WriteLine("WHITE");
}*/


// ps1 part2 task 13

/*int n = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());
int sum = 0;

while (n > 0)
{
    sum += n % k;
    n = n / k;
}
Console.WriteLine(sum);
*/

// ps1 part 3 task 15

/*Random r = new Random();
int len = int.Parse(Console.ReadLine());
int k2 = int.Parse(Console.ReadLine());
int[] arr = new int[len];
int c = 0, max = 0;
for (int i = 0; i < len; i++)
{
    arr[i] = r.Next(10);
}
for (int i = 0; i < len; i++)
{
    if (arr[i] == k2)
    {
        c++;
    }
    else
    {
        if (c > max) { max = c; }
        c = 0;
    }
}*/

//Console.WriteLine(max);

// ps1 part 4 task 

string num1 = Console.ReadLine();
int num_int = int.Parse(num1);
if ((num_int == 5) || (num_int % 10 == 0))
{
    Console.WriteLine("Тут по хитрому не получится)");
}
else
{
    Console.Write($"{num1} = ");
    num1 = num1.Remove(num1.Length - 1);
    int num2 = int.Parse(num1) + 1;
    int result = int.Parse(num1) * num2 * 100 + 25;
    Console.Write($"{num1} * {num2} * 100 + 25 = {result}");
}











































































































































































































































































































