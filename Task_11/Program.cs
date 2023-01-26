// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int[] array = new int[123]; // создание массива длинной 123 числа
int Count = 0; //счетчик

for(int i = 0; i < array.Length; i++) 
{
    array[i] = i;
    if ( array[i]%2 !=0)
    {
    Count = Count + 1;
    }
}
Console.WriteLine(Count);