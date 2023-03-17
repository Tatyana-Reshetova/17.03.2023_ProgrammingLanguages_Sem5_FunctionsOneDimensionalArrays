// Задайте массив из 12 элементов, заполненный случайными числами от -9 до 9.
//Найти сумму положительных и отрицательных эллементов массива.

Console.Clear();
int [] array = GetBinaryArray(12);

Console.WriteLine($"[   {String.Join(", ", array)}   ]");
//Console.WriteLine($"[   {String.Join(", ", sum(array))}   ]");


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

//Сумма положительных и отрицательных массива через
// foreach (перебирает поочередно массив не обращаясь к индексу)

int [] SumPosNeg (int [] array)
{
    int [] result = new int [2];
    foreach (int el in array)
    {
        result[0] += el > 0 ? el : 0; 
        result[1] += el < 0 ? el : 0; 
    }
    return result;
}
 Console.WriteLine($"[   {String.Join(", ", SumPosNeg(array))}   ]");