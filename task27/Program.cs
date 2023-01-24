// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// метод суммы чисел в числе
void SumOfNums(int number)
{
    int summ = 0;
    while (number != 0)
    {
        int last = number % 10;
        summ += last;
        number /= 10;
    }
    Console.WriteLine(summ);
}

// получение данных 
int GetNum(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return (number);
}

// ввод данных от пользователя
int number = GetNum("Введите число: ");
Console.Write($"{number} -> ");

// вызов метода
SumOfNums(number);
