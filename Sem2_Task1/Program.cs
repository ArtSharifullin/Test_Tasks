using Sem2_Task1;

var path = "C:\\Users\\Moibaty\\source\\repos\\Test_Tasks\\Sem2_Task1\\seg.txt";
var a = new GraphicPic(path);

Console.WriteLine("------------------------------Выводим список сегментов-------------------------------\n");
a.Show();
Console.WriteLine();

Console.WriteLine("------------------------------Вставляем в список новый сегмент-------------------------------\n");
var s = new Segment(90, 20, 30, 40);
a.Insert(s);
a.Show();
Console.WriteLine();

Console.WriteLine("------------------------------Вставляем уже существующий сегмент-------------------------------\n");
a.Insert(s);
a.Show();
Console.WriteLine();

Console.WriteLine("------------------------------Создаём список отрезков с углами 30 и 45 гр.-------------------------------\n");
var b = a.angleList();
b.Show();
Console.WriteLine();

Console.WriteLine("------------------------------Создаём список отрезков, длинна-------------------------------");
Console.WriteLine("--------------------------которых находится в выбранном диапазоне---------------------------\n");
var c = a.lengthList(2, 10);
c.Show();
Console.WriteLine();

Console.WriteLine("------------------------------Сортируем список-------------------------------\n");
a.Sort();
a.Show();



















