using Tyuiu.VlasenkoAE.Sprint1.Task3.V16.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Власенко А. Е. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #16                                                             *");
Console.WriteLine("* Выполнил: Власенко Артём Евгеньевич | ИСТНб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу, которая вычисляет и печатает коэффициент            *");
Console.WriteLine("* приведенного квадратного уравнения, корнями которого являются           *");
Console.WriteLine("* введенные пользователем два вещественных числа.                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double x1;
double x2;

Console.WriteLine("Введите значение X1:");
x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите значение X2:");
x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Коэффициент приведенного квадратного уравнения = " + ds.CoeffOfQuadraticEquation(x1, x2));

Console.ReadLine();