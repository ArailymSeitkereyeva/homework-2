//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели от 1 до 7");
void WeekDay(int arg)
{
    if (arg == 6 || arg == 7) Console.WriteLine("Выходной день.");
    else if (arg >= 1 && arg <= 5) Console.WriteLine("Будний день.");
    else Console.WriteLine("Ошибка: от 1 до 7");
}

try
{
    int numWeek =Convert.ToInt32(Console.ReadLine());
    WeekDay(numWeek);
}
catch
{
    Console.WriteLine("Ошибка выполнения");
}