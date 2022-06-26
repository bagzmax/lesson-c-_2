System.Console.Write("Введите значение дня недели: ");
int day = Convert.ToInt32(Console.ReadLine()); // преобразует строковый тип в числовой

//int day = 5;                                                          
//System.Console.WriteLine(day);

System.Console.Write("День недели: ");

if (day == 1)
{
    System.Console.WriteLine("Понедельник");
}
else if (day == 2)
{
    System.Console.WriteLine("Вторник");
}
else if (day == 3)
{
    System.Console.WriteLine("Среда");
}
else if (day == 4)
{
    System.Console.WriteLine("Четверг");
}
else if (day == 5)
{
    System.Console.WriteLine("Пятница");
}
else
{
    System.Console.WriteLine("Неверный код");
}
