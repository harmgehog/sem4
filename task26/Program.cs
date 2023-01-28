// Решение в группах задач:
// Задача 26: Напишите программу, которая принимает на вход 
// число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// метод длины
void Len(int number)
{
    int count = 0;
    while (number != 0)
    {
        count += 1;
        number /= 10;
    }
    Console.WriteLine(count);
}

// получение данных 
int GetNum(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine()!);
    return (number);
}

// ввод данных от пользователя
int number = GetNum("Введите число: ");
Console.Write($"{number} -> ");

// вызов метода
Len(number);


// Well Done!!! Или Используем свойство Length. 
// Кроме строк с -01234 
Console.Write(Console.ReadLine()!.Length);
