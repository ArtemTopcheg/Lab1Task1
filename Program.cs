//Задача 1

Console.WriteLine("Введите длины сторон прямоуголнька (целые числа):");
string number1, number2;
number1 = Console.ReadLine();
int a = Convert.ToInt32(number1);
number2 = Console.ReadLine();
int b = Convert.ToInt32(number2);
Console.WriteLine("Площадь прямоугольника = " + a * b);