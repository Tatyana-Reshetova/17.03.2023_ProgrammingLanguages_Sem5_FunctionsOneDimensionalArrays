// Задача 32. Напишите программу замены элементов массива:
// положительные элементы замените на соответствующие отрицательные и наоборот.
// [ -4, - 8, 8, 2 ] -> [ 4, 8, - 8, - 2 ]   String.Join (", ", array)*/

int [] GetRandomArray (int size, int minValue, int maxValue)
{
    int[] result = new int [size];
    for (int i = 0; i<size;i++)
    {
        result [i] = new Random().Next(minValue,maxValue+1);
    }
    return result;
}

int [] GetChangeArray (int [] array)
{
    for (int i = 0; i<array.Length;i++)
    {
        array [i] *= -1;
    }
    return array;
}

Console.Clear();
int [] startArray = GetRandomArray(6, -10, 10);
Console.WriteLine($"[   {String.Join(", ", startArray)}   ]");
Console.WriteLine($"[   {String.Join(", ", GetChangeArray(startArray))}   ]");


