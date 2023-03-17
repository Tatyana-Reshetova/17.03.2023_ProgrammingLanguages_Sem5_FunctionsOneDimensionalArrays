﻿// Задайте массив из 12 элементов, заполненный случайными числами от -9 до 9.
//Найти сумму положительных и отрицательных эллементов массива.

Console.Clear();
int [] array = GetBinaryArray(12);

Console.WriteLine($"[   {String.Join(", ", array)}   ]");
Console.WriteLine($"[   {String.Join(", ", sum(array))}   ]");


int [] GetBinaryArray (int size){
    int[] result = new int [size];
    for (int i = 0; i<size;i++)
    {
        result [i] = new Random().Next(-9,10);
    }
    return result;
}

int [] sum (int [] array)
{
    int negativ = 0;
    int positiv = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<0) {negativ=negativ+array[i];}
        else {positiv = positiv+array[i];}
    }
    int [] SumNegativPositiv = {negativ, positiv};
    return SumNegativPositiv;
}  
