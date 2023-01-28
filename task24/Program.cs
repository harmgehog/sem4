// Задача 24: Напишите программу, которая принимает на вход 
// число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

static void SummOfNums(int number)
{
    int result = 0;
    for (int i = 1; i < number; i++, result += i);
    Console.Write(result);
}

// получение данных 

static int GetNum(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine()!);
    return (number);
}

// ввод данных от пользователя 

int number = GetNum("Введите число: ");
Console.Write($"{number} -> ");

// запуск метода
SummOfNums(number);
