﻿//**Задача 35:**Задайте одномерный массив из 123 случайных чисел [0: 1000]. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//*Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123*
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2]-> 0
//[10, 11, 12, 13, 14]-> 5

int [] GetRandomArray (int size, int minValue, int maxValue)
{
    int[] result = new int [size];
    for (int i = 0; i<size;i++)
    {
        result [i] = new Random().Next(minValue,maxValue+1);
    }
    return result;
}

int GetCountElements(int[] array, int leftRange, int rigthRange)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item >= leftRange && item <= rigthRange) count++;
    }
    return count;
}

Console.Clear();
int [] array = GetRandomArray(123, 0, 1000);
Console.WriteLine($"[   {String.Join(", ", array)}   ]");
Console.WriteLine($"Количество элементов массива, лежащих в отрезке [10,99] равно {GetCountElements(array,10,99)}");


