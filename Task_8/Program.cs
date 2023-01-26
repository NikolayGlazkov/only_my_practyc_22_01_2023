// Определить, присутствует ли в заданном массиве, некоторое число
int a = int.Parse(Console.ReadLine()); //ввод числа которое мы ищем
int[] array = new int[10]; // создание массива длинной 10 чисел
Random random = new Random(); //рандом


for(int i = 0; i < array.Length; i++) //заполняет цикл случайными числами, самый сложный момент для понимания мною
{
    array[i] = random.Next(0,10);
}

foreach (int num in array) //Каждая итерация цикла присваивает значение текущего элемента массива переменной num и выводит его
{
    Console.Write(num + " ");
}

bool isFound = false; //Булевая переменная 
for(int i = 0; i < array.Length; i++)
{
if (array[i] == a)

{
    Console.WriteLine("В массиве есть число числоT:"+a);
    isFound = true;
    break;
}
}
if(!isFound) 
{
    Console.WriteLine("В массиве нет числа:"+a);
}