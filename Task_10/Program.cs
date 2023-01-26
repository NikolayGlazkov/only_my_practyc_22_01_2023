// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] array = new int[123]; // создание массива длинной 123 числа
int Count = 0; //счетчик

for(int i = 0; i < array.Length; i++) 
{
    array[i] = i;
    if (array[i]>10 && array[i]<99)
    {
    Count = Count + 1;
    }
}
Console.WriteLine(Count);
