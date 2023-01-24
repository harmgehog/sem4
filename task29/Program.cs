// Задача 29: Напишите программу, которая задаёт массив из 
// 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// условия задачи и пример противоречат сами себе! на входе не 8 элементов.
// также не сказано вводятся ли числа массива или берется рандом(не указан диапазон).



// обработка и вывод массива 
void GetArray(string text)
{
    Console.Write(text);
    int[] arr = new int[int.Parse(Console.ReadLine())];
    Console.Write("Верхняя граница диапазона чисел: ");
    int upper = int.Parse(Console.ReadLine());
    Console.Write("Нижняя граница диапазона чисел: ");
    int lower = int.Parse(Console.ReadLine());

    Random rnd = new Random();
    for (int i = 0; i < arr.Length; ++i)
    {
        
        arr[i] = rnd.Next(upper, lower);
    }
    
    foreach (int i in arr) Console.Write("{0} ", i); // подумалось что так удобнее массив в печать
}

// ввод данных от пользователя
GetArray("Введите количество элементов массива: "); // если не 8
