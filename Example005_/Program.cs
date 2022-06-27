// Задано два числа, определить если кратно 2 к 1, то выводим сообщение, если нет, то показываем остаток от деления.

Console.Write("Введите первое число: ");
int numberone = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int numbertwo = int.Parse(Console.ReadLine());

if (numberone % numbertwo == 0)
{
   System.Console.WriteLine($"{numberone} кратно {numbertwo}"); 
}
else
{
    System.Console.WriteLine(
        $"{numberone} не кратно {numbertwo}" + 
        $" остаток {numberone % numbertwo}"
        );
}
