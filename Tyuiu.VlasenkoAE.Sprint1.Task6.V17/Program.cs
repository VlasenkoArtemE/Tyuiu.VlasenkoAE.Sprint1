using Tyuiu.VlasenkoAE.Sprint1.Task6.V17.Lib;

DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнил: Власенко А. Е. | ИСТНб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Работа со строками, класс String                                  *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #17                                                              *");
Console.WriteLine("* Выполнил: Власенко Артём Евгеньевич | ИСТНб-25-1                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что           *");
Console.WriteLine("* строка является перевертышем.                                           *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Введите текст: ");
string str = Console.ReadLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

if (ds.CheckPalindrome(str) == true)
    Console.WriteLine("Строка является перевертышем.");
else
    Console.WriteLine("Строка не является перевертышем.");

    Console.ReadKey();

