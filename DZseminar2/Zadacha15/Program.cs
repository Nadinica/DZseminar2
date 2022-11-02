// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Напишите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
while (day >= 1 || day <= 7)
{
    if (day == 6|| day == 7)
    {
        Console.WriteLine("Выходной день!");
        day = Convert.ToInt32(Console.ReadLine());
    }
    if( day >=1 || day>=5)
    {
        Console.WriteLine("Рабочий день!");
        day = Convert.ToInt32(Console.ReadLine());
    }
    else
Console.WriteLine("Ошибка: в неделе только 7 дней");
day = Convert.ToInt32(Console.ReadLine());
}



