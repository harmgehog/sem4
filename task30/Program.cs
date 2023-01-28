// Задача 30: Напишите программу, которая выводит массив из 8 
// элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] arr = new int[8];
for (int i = 0; i < arr.Length; ++i) 
{
    Random rnd = new Random();
    arr[i] = rnd.Next(2);
}

foreach (int i in arr) Console.Write("{0} ", i);
