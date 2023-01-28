// Решение в группах задач:
// Задача 28: Напишите программу, которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// метод мультипликации
void Mult(int number)
{
    int count = 1;
    for (int i = 1; i <= number; count *= i, i++);
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
Mult(number);

// Это все!!!
