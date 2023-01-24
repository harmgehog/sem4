// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//  забыли написать в описакнии что запрещено использование Math.Pow

// метод Х в степени У
static void MultAB(int a, int b)
{
    int mult = a;
    for (int i = 1; i < b; i++, mult *= a);
    Console.WriteLine(mult);
}

// получение данных 
static int GetNum(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return (number);
}

// ввод данных от пользователя
int a = GetNum("Введите число A: ");
int b = GetNum("Введите степень B: ");
Console.Write($"{a}, {b} -> ");

// вызов метода
MultAB(a, b);

