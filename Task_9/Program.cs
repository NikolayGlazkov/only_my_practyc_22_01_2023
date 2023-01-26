// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] array = new int[10]; // создание массива длинной 10 чисел
Random random = new Random(); //рандом
int count = 0;
int count1 = 0;

for(int i = 0; i < array.Length; i++) //заполняет цикл случайными числами, самый сложный момент для понимания мною
{
    array[i] = random.Next(100,999);
}

foreach (int num in array) //Каждая итерация цикла присваивает значение текущего элемента массива переменной num и выводит его
{
    Console.Write(num + " ");
}

bool isFound = false; //Булевая переменная 
for(int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)

{
    count +=1;
   
}

if (array[i] % 2 != 0)
{
    count1 +=1;
}
}
    Console.WriteLine();
    Console.WriteLine("количество четных " + count);
    Console.WriteLine("количество нечетных чисел " + count1);