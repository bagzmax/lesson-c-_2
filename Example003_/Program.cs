Console.Write("Введите трехзначное число: ");

string str = Console.ReadLine(); // ввод строкового типа данных

// *int number = int.Parse(str);* // принять (Parse) строковый в числовой тип

// *int.TryParse(str out number);*
// булевая проверка, удалось ли спарсить, переменной number присваивается 0 или 1
// out - оператор обязывает изменять значение внутри функции TryParse для number
// Если с цифрами будут вводиться буквы, то выдаст else

int number;
if (int.TryParse(str, out number))
{
    System.Console.WriteLine("Удалось");
}
else
{
    System.Console.WriteLine("Не удалось");
}
System.Console.WriteLine(number);

//int number = Convert.ToInt32(Console.ReadLine());
//int number = 1556;
//System.Console.WriteLine(number);

if (number > 100 && number < 1000) // число трехзначное или нет
{
    System.Console.WriteLine(number /10 % 10);
}
else
{
    System.Console.WriteLine("Failed");
}
